namespace BasicFacebookFeatures
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation7 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation8 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonCalctulation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonClearChart = new System.Windows.Forms.Button();
            this.buttonCalculationAmountPic = new System.Windows.Forms.Button();
            this.textBoxPicRangeTo = new System.Windows.Forms.TextBox();
            this.textBoxPicRangeFrom = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(18, 19);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(269, 35);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(18, 62);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(269, 35);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // checkBoxRememberUser
            // 
            this.checkBoxRememberUser.AutoSize = true;
            this.checkBoxRememberUser.Location = new System.Drawing.Point(18, 106);
            this.checkBoxRememberUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.Size = new System.Drawing.Size(140, 24);
            this.checkBoxRememberUser.TabIndex = 53;
            this.checkBoxRememberUser.Text = "Remember Me";
            this.checkBoxRememberUser.UseVisualStyleBackColor = true;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(10, 26);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(285, 235);
            this.pictureBoxProfile.TabIndex = 54;
            this.pictureBoxProfile.TabStop = false;
            // 
            // chart1
            // 
            lineAnnotation7.Name = "RangeOfYears";
            this.chart1.Annotations.Add(lineAnnotation7);
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(18, 414);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series10.Legend = "Legend1";
            series10.Name = "Female";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series11.Legend = "Legend1";
            series11.Name = "Male";
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Size = new System.Drawing.Size(657, 254);
            this.chart1.TabIndex = 56;
            this.chart1.TabStop = false;
            this.chart1.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(371, 379);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 26);
            this.textBox1.TabIndex = 57;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(474, 379);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(97, 26);
            this.textBox2.TabIndex = 58;
            // 
            // buttonCalctulation
            // 
            this.buttonCalctulation.Enabled = false;
            this.buttonCalctulation.Location = new System.Drawing.Point(579, 368);
            this.buttonCalctulation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCalctulation.Name = "buttonCalctulation";
            this.buttonCalctulation.Size = new System.Drawing.Size(98, 42);
            this.buttonCalctulation.TabIndex = 59;
            this.buttonCalctulation.Text = "Calculation";
            this.buttonCalctulation.UseVisualStyleBackColor = true;
            this.buttonCalctulation.Click += new System.EventHandler(this.calculation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 40);
            this.label1.TabIndex = 60;
            this.label1.Text = "Enter in what range of years you would like to \r\nreceive the number of members";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.webBrowser1);
            this.groupBox1.Location = new System.Drawing.Point(911, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 987);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 22);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(711, 962);
            this.webBrowser1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 133);
            this.button1.TabIndex = 62;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart2
            // 
            lineAnnotation8.Name = "RangeOfYears";
            this.chart2.Annotations.Add(lineAnnotation8);
            chartArea8.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart2.Legends.Add(legend8);
            this.chart2.Location = new System.Drawing.Point(18, 748);
            this.chart2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Legend = "Legend1";
            series12.Name = "Amount of Pictures";
            this.chart2.Series.Add(series12);
            this.chart2.Size = new System.Drawing.Size(657, 254);
            this.chart2.TabIndex = 63;
            this.chart2.TabStop = false;
            this.chart2.Text = "chart2";
            // 
            // buttonClearChart
            // 
            this.buttonClearChart.Location = new System.Drawing.Point(578, 698);
            this.buttonClearChart.Name = "buttonClearChart";
            this.buttonClearChart.Size = new System.Drawing.Size(99, 40);
            this.buttonClearChart.TabIndex = 64;
            this.buttonClearChart.Text = "Clear Chart";
            this.buttonClearChart.UseVisualStyleBackColor = true;
            this.buttonClearChart.Click += new System.EventHandler(this.buttonClearChart_Click);
            // 
            // buttonCalculationAmountPic
            // 
            this.buttonCalculationAmountPic.Enabled = false;
            this.buttonCalculationAmountPic.Location = new System.Drawing.Point(474, 698);
            this.buttonCalculationAmountPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCalculationAmountPic.Name = "buttonCalculationAmountPic";
            this.buttonCalculationAmountPic.Size = new System.Drawing.Size(98, 42);
            this.buttonCalculationAmountPic.TabIndex = 67;
            this.buttonCalculationAmountPic.Text = "Calculation";
            this.buttonCalculationAmountPic.UseVisualStyleBackColor = true;
            this.buttonCalculationAmountPic.Click += new System.EventHandler(this.buttonCalculationAmountPic_Click);
            // 
            // textBoxPicRangeTo
            // 
            this.textBoxPicRangeTo.Location = new System.Drawing.Point(369, 709);
            this.textBoxPicRangeTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPicRangeTo.Name = "textBoxPicRangeTo";
            this.textBoxPicRangeTo.Size = new System.Drawing.Size(97, 26);
            this.textBoxPicRangeTo.TabIndex = 66;
            // 
            // textBoxPicRangeFrom
            // 
            this.textBoxPicRangeFrom.Location = new System.Drawing.Point(266, 709);
            this.textBoxPicRangeFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPicRangeFrom.Name = "textBoxPicRangeFrom";
            this.textBoxPicRangeFrom.Size = new System.Drawing.Size(95, 26);
            this.textBoxPicRangeFrom.TabIndex = 65;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.pictureBoxProfile);
            this.groupBox2.Location = new System.Drawing.Point(294, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 275);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(301, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 246);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "label5";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 1015);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonCalculationAmountPic);
            this.Controls.Add(this.textBoxPicRangeTo);
            this.Controls.Add(this.textBoxPicRangeFrom);
            this.Controls.Add(this.buttonClearChart);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCalctulation);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.checkBoxRememberUser);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.CheckBox checkBoxRememberUser;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonCalctulation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button buttonClearChart;
        private System.Windows.Forms.Button buttonCalculationAmountPic;
        private System.Windows.Forms.TextBox textBoxPicRangeTo;
        private System.Windows.Forms.TextBox textBoxPicRangeFrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

