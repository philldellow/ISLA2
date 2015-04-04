using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Facebook;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace ISLA2.Models
{
    public class MyFB
    {
        public static string FacebookFeed(string donteEsta)
        {
            return donteEsta= "oh my fuck";
        }

        private FacebookClient myFBAPI;
        private string appId;
        private string apiKey;
        private string appSecret;

        #region Application Settings Properties
        /// <summary>
        /// Get And Set Application ID
        /// </summary>
        public String ApplicationID
        {
            get
            {
                return appId;
            }
            set
            {
                appId = value;
            }
        }

        /// <summary>
        /// Get And Set API Key
        /// </summary>
        public String APIKey
        {
            get
            {
                return apiKey;
            }
            set
            {
                apiKey = value;
            }
        }

        /// <summary>
        /// Get And Set Application Secret
        /// </summary>
        public String ApplicationSecret
        {
            get
            {
                return appSecret;
            }
            set
            {
                appSecret = value;
            }
        }

        /// <summary>
        /// Get And Set Access Token
        /// </summary>
        public String AccessToken
        {
            get
            {
                return myFBAPI.AccessToken;
            }
            set
            {
                myFBAPI.AccessToken = value;
            }
        }
        #endregion

        //Constructor        
        public MyFB()
        {
            myFBAPI = new FacebookClient();
        }

        //public String GetMyName()
        //{
        //    try
        //    {
        //        JsonObject me = myFBAPI.Get("/me");
        //        return me.Dictionary["name"].String;
        //    }
        //    catch (FacebookApiException err)
        //    {
        //        return err.Message;
        //    }
        //}

        public String GetAccessToken(string code)
        {
            //create the constructor with post type and few data
            MyWebRequest myRequest = new MyWebRequest("https://graph.facebook.com/oauth/access_token", "GET", "client_id=" + this.ApplicationID + "&client_secret=" + this.ApplicationSecret + "&code=" + code + "&redirect_uri=http:%2F%2Flocalhost:5176%2F");

            string accessToken = myRequest.GetResponse().Split('&')[0];
            accessToken = accessToken.Split('=')[1];

            return accessToken;
        }

    }
}