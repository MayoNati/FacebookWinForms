using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class FacebookLogic
    {
        public string AccessToken { get;  set; }
        private FacebookWrapper.LoginResult m_LoginResult;
        private FacebookWrapper.ObjectModel.User m_LoggInUser;
        List<Post> m_PostList = new List<Post>();
        List<Album> m_AlbumList = new List<Album>();
        List<User> m_FriendsList = new List<User>();
        private UserProfile userProfile;
        public bool Login()
        {
            bool flag = false;
            Clipboard.SetText("design.patterns20cc");

            FacebookWrapper.LoginResult m_LoginResult = FacebookService.Login("289790089925279", "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos"
                );

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                AccessToken = m_LoginResult.AccessToken;
                m_LoggInUser = m_LoginResult.LoggedInUser;
                userProfile = new UserProfile()
                {
                    UserName = m_LoggInUser.UserName,
                    Birthday = m_LoggInUser.Birthday,
                    Hometown = m_LoggInUser.Hometown.Name,
                    Gender = m_LoggInUser.Gender.ToString(),
                    Email = m_LoggInUser.Email.ToString()
                };

                
                

                //FaceBookData();
                flag = true;
            }

            return flag;

        }

        public string SetUserPic()
        {
            string url=null;
            if (m_LoggInUser != null)
            {
                //userPic = new PictureBox();

                url= m_LoggInUser.PictureNormalURL;
            }
            return url;
        }

        public bool Logout()
        {
            bool flag = false;
            FacebookService.LogoutWithUI();
            if (string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                flag = true;
            }

            return flag;
        }

        public void Connect(string i_AccessToken)
        {
            m_LoginResult=FacebookService.Connect(i_AccessToken);
            m_LoggInUser = m_LoginResult.LoggedInUser;
            AccessToken = m_LoginResult.AccessToken;

            userProfile = new UserProfile()
            {
                UserName = m_LoggInUser.UserName,
                Birthday = m_LoggInUser.Birthday,
                Hometown = m_LoggInUser.Hometown.Name,
                Gender = m_LoggInUser.Gender.ToString(),
                Email = m_LoggInUser.Email.ToString()
            };
        }

        public string GetUserLocation()
        {
            string addressName=string.Empty;
            try
            {
                addressName = m_LoggInUser.Location.Name;
            }
            catch
            {
                throw new InvalidOperationException("Get Location name failed");
            }

            return addressName;
        }

        public void FetchByRangeYears(int i_yearFrom, int i_yearTo,out int i_CountOfFemale, out int i_CountOfMale)
        {
            int countFemale=0;
            int countMale = 0;
            if (m_FriendsList.Count == 0)
            {
                updateFriendsListList();
            }
            try
            {
                foreach (User friend in m_FriendsList)
                {
                    string year = friend.Birthday.Substring(6, 4);
                    if (int.TryParse(year, out int validateYear))
                    {
                        if (validateYear >= i_yearTo && validateYear <= i_yearFrom)
                        {
                            //userList.Add(friend);
                            if (friend.Gender == User.eGender.female)
                            {
                                countFemale++;
                            }
                            else if (friend.Gender == User.eGender.male)
                            {
                                countMale++;
                            }
                        }
                    }
                }
                i_CountOfFemale = countFemale;
                i_CountOfMale = countMale;

            }
            catch (Exception)
            {
                throw;
            }
          
        }

        public int FetchPicAmountByRangeDate(double i_yearFrom, double i_yearTo)
        {       
            int[] months = new int[12];
            Dictionary<int, int[]> picCountByData=fetchAllPostByPicTypeAndTime();
            int count = 0 ;

            foreach (KeyValuePair<int,int[]> picCountByDataItem in picCountByData)
            {
                if(i_yearFrom<= picCountByDataItem.Key && i_yearTo >= picCountByDataItem.Key)
                {
                    //var s=picCountByDataItem.Value.Sum();
                    count+= picCountByDataItem.Value.Sum();
                }                
            }
            return count;
            ;
            //Dictionary<int, int[]> picCountByData = new Dictionary<int, int[]>();
            //Dictionary<int, Post> postDic = new Dictionary<int, Post>();

            //try
            //{
            //    List<Album> albums = new List<Album>();
            //    List<Post> postList = new List<Post>();
            //    foreach (Album album in m_LoggInUser.Albums)
            //    {
            //        albums.Add(album);
            //    }

            //    foreach (Post post in m_LoggInUser.Posts)
            //    {
            //        if(post.Type== FacebookWrapper.ObjectModel.Post.eType.photo)
            //        {
            //            postList.Add(post);
            //            int year= post.CreatedTime.Value.Year;
            //            int month = post.CreatedTime.Value.Month;

            //            if (picCountByData.ContainsKey(year))
            //            {                            
            //                picCountByData[year][month-1] += 1;
            //            }
            //            else
            //            {
            //                picCountByData.Add(year, new int[12]);
            //                picCountByData[year][month - 1] += 1;
            //            }                    
            //        }                 
            //    }
            //    ;

            //}
            //catch (Exception)
            //{
            //    throw;
            //}

        }

        private Dictionary<int, int[]> fetchAllPostByPicTypeAndTime()
        {
            if (m_PostList.Count == 0)
            {
                updatePostList();
            }
            
            Dictionary<int, int[]> picCountByData = new Dictionary<int, int[]>();
            try
            {
                foreach (Post post in m_PostList)
                {
                    if (post.Type == FacebookWrapper.ObjectModel.Post.eType.photo)
                    {
                       
                        int year = post.CreatedTime.Value.Year;
                        int month = post.CreatedTime.Value.Month;

                        if (picCountByData.ContainsKey(year))
                        {
                            picCountByData[year][month - 1] += 1;
                        }
                        else
                        {
                            picCountByData.Add(year, new int[12]);
                            picCountByData[year][month - 1] += 1;
                        }
                    }
                }
             ;
            }
            catch (Exception)
            {
                return null;
            }
            return picCountByData;
        }

        private void updatePostList()
        {
            m_PostList.Clear();
            try
            {
                foreach (Post post in m_LoggInUser.Posts)
                {
                    m_PostList.Add(post);
                }            
            }
            catch 
            {
                throw new InvalidOperationException("Update Posts failed");
            }
        }

        private void updateAlbumListList()
        {
            m_AlbumList.Clear();
            try
            {
                foreach (Album album in m_LoggInUser.Albums)
                {
                    m_AlbumList.Add(album);
                }
            }
            catch
            {
                throw new InvalidOperationException("Update Posts failed");
            }
        }

        private void updateFriendsListList()
        {
            m_FriendsList.Clear();
            try
            {
                foreach (User friend in m_LoggInUser.Friends)
                {
                    m_FriendsList.Add(friend);
                }
            }
            catch
            {
                throw new InvalidOperationException("Update Posts failed");
            }
        }

        public UserProfile GetDetailes()
        {
            return userProfile;
        }
    }

    public class UserProfile
    {
        public string UserName { get; set; }
        public string Birthday { get; set; }
        public string Gender { get; set; }
        public string Hometown { get; set; }

        public string Email { get; set; }
    }
}
