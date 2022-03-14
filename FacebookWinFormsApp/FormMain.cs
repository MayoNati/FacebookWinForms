using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CefSharp.DevTools.Emulation;
using CefSharp.Structs;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using Message = FacebookWrapper.ObjectModel.Message;

namespace BasicFacebookFeatures
{

    public partial class FormMain : Form
    {
        FacebookLogic facebookLogic;
        private AppSettings m_AppSettings;

        public FormMain()
        {
            InitializeComponent();
            facebookLogic = new FacebookLogic();
            this.StartPosition = FormStartPosition.Manual;
            m_AppSettings = AppSettings.LoadFromFile();
            this.Size = m_AppSettings.LastWindowSize;
            this.Location = m_AppSettings.LastWindowLocation;
            this.checkBoxRememberUser.Checked = m_AppSettings.RemmeberUser;
            //m_AppSettings.LastAccessToken = "EAAEHkANekp8BAGAstTjVnC3u7PRZAi8ct5DI152Ou1aky9SJpuDFfzbyqNz0mTpBqyabZAumcPzkzFNLB9ecF6WA67NE2LmcoZAGOCsBydU88tKganzMJ8Bx9ngTcvIluQmZAWbOGLmbjf3IbyHhQ164BulGsmro2AZByJvfzqEeoD1ZCQdEFn5mTFsALewMYZD";
            if (m_AppSettings.RemmeberUser && !string.IsNullOrEmpty(m_AppSettings.LastAccessToken))
            {
                facebookLogic.Connect(m_AppSettings.LastAccessToken);
                pictureBoxProfile.LoadAsync(facebookLogic.SetUserPic());
                setAddressOnMap(facebookLogic.GetUserLocation());
                buttonCalctulation.Enabled = true;
                buttonCalculationAmountPic.Enabled = true;
                label2.Text = (facebookLogic.GetDetailes().UserName);
                label3.Text = (facebookLogic.GetDetailes().Birthday);
                label4.Text = (facebookLogic.GetDetailes().Email);
                label5.Text = (facebookLogic.GetDetailes().Hometown);

            }
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }
        //LoginResult m_LoginResult;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (facebookLogic.Login() == true)
            {
                //buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                //"EAAEHkANekp8BAGAstTjVnC3u7PRZAi8ct5DI152Ou1aky9SJpuDFfzbyqNz0mTpBqyabZAumcPzkzFNLB9ecF6WA67NE2LmcoZAGOCsBydU88tKganzMJ8Bx9ngTcvIluQmZAWbOGLmbjf3IbyHhQ164BulGsmro2AZByJvfzqEeoD1ZCQdEFn5mTFsALewMYZD"
                pictureBoxProfile.LoadAsync(facebookLogic.SetUserPic());
                setAddressOnMap(facebookLogic.GetUserLocation());
                if (m_AppSettings.RemmeberUser && facebookLogic.AccessToken != null)
                {
                    m_AppSettings.LastAccessToken = facebookLogic.AccessToken;
                    buttonCalctulation.Enabled = true;
                    buttonCalculationAmountPic.Enabled = true;
                    label2.Text = (facebookLogic.GetDetailes().UserName);
                    label3.Text = (facebookLogic.GetDetailes().Birthday);
                    label4.Text = (facebookLogic.GetDetailes().Email);
                    label5.Text = (facebookLogic.GetDetailes().Hometown);

                }
            }
            else
            {
                buttonCalctulation.Enabled = false;
                buttonCalculationAmountPic.Enabled = false;
                MessageBox.Show("Login Failed");
            }
        }


        public void InsertPersonalData()
        {



        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            m_AppSettings.LastWindowLocation = this.Location;
            m_AppSettings.LastWindowSize = this.Size;
            m_AppSettings.RemmeberUser = this.checkBoxRememberUser.Checked;
            if (m_AppSettings.RemmeberUser)
            {
                m_AppSettings.LastAccessToken = facebookLogic.AccessToken;
                m_AppSettings.SaveToFile();
            }
            else
            {
                //facebookLogic.AccessToken = "";
                //m_AppSettings.LastAccessToken = null;
            }
        }
        private void setAddressOnMap(string i_Address)
        {
            string url;
            url = string.Format("https://www.google.com/maps/place/{0}&sourceid=opera&ie=UTF-8&oe=UTF-8", i_Address);
            url = string.Format("https://www.google.com/maps/place/{0}", i_Address);

            string url1 = string.Format("https://www.google.com?q={0}", i_Address);
            webBrowser1.Navigate(new Uri(url));

            //webBrowser1.Navigate(url1.Trim());
        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (facebookLogic.Logout() == true)
            {
                buttonLogin.Text = "Login";
                buttonCalctulation.Enabled = false;
                buttonCalculationAmountPic.Enabled = false;

            }
            else
            {
                buttonCalctulation.Enabled = true;
                buttonCalculationAmountPic.Enabled = true;

                MessageBox.Show("logout failed");
            }
        }


        private void fetchByRangeYears(int i_yearTo, int i_yearFrom)
        {
            int count = 0;
            int countOfFemale = 0;
            int countOfMale = 0;
            List<User> userList = new List<User>();
            facebookLogic.FetchByRangeYears(i_yearTo, i_yearFrom, out countOfFemale, out countOfMale);

            int countFriends = userList.Count;
            string tempString = i_yearTo.ToString() + "-" + i_yearFrom.ToString();
            if (countOfMale == 0 && countOfFemale == 0)
            {
                chart1.Series["Male"].Points.AddXY(tempString, countOfMale);

            }
            if (countOfMale > 0)
            {
                chart1.Series["Male"].Points.AddXY(tempString, countOfMale);
                chart1.Series["Male"].IsValueShownAsLabel = true;
            }
            if (countOfFemale > 0)
            {
                chart1.Series["Female"].Points.AddXY(tempString, countOfFemale);
                chart1.Series["Female"].IsValueShownAsLabel = true;
            }
        }
        private void calculation_Click(object sender, EventArgs e)
        {
            int input1 = Convert.ToInt32(textBox1.Text);
            int input2 = Convert.ToInt32(textBox2.Text);

            if (input1 < input2)
            {
                fetchByRangeYears(input1, input2);
            }
            else
            {
                MessageBox.Show("The range is incorrect");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void buttonClearChart_Click(object sender, EventArgs e)
        {
            chart2.Series["Amount of Pictures"].Points.Clear();            
        }

        private void buttonCalculationAmountPic_Click(object sender, EventArgs e)
        {
            // facebookLogic.FetchPicAmountByRangeDate(2017,2018);
            double from = 0;
            double.TryParse(textBoxPicRangeFrom.Text, out from);
            double to = 0;
            double.TryParse(textBoxPicRangeTo.Text, out to);
            chart2.Series["Amount of Pictures"].Points.AddXY(string.Format("{0}-{1}", from, to), facebookLogic.FetchPicAmountByRangeDate(from, to));
            chart2.Series["Amount of Pictures"].IsValueShownAsLabel = true;

            //for (int i = 2011; i < 2021; i++)
            //{
            //    chart2.Series["Amount of Pictures"].Points.AddXY(i.ToString(), facebookLogic.FetchPicAmountByRangeDate(i, i));
            //    chart2.Series["Amount of Pictures"].IsValueShownAsLabel = true;
            //}
            //chart2.Series["Count"].Points.AddXY("2017-2018", facebookLogic.FetchPicAmountByRangeDate(2017, 2018));
            //chart2.Series["Count"].IsValueShownAsLabel = true;
            //chart2.Series["Count"].Points.AddXY("2017-2020", facebookLogic.FetchPicAmountByRangeDate(2017, 2020));
            //chart2.Series["Count"].IsValueShownAsLabel = true;
        }
    }
}
