using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Facebook;
using ISLA2.Models;

namespace ISLA2.Controllers
{


    public class FaceBookController : ApiController
    {
        //// GET: api/Engine
        //public GameState Get()
        //{
        //    GameState reply = new GameState("CatLady", false);

        //    return reply;
        //}

        // GET: api/Facebook/feed
        [Route("api/Facebook/feed")]
        [AcceptVerbs("GET")]
        public string FBFeed()
        {   MyFB.FacebookFeed("now we see");
            var client = new FacebookClient();
            dynamic me = client.Get("zuck")
            return me;
        }

        // POST: api/Facebook/feed
        [Route("api/Facebook/feed")]
        [AcceptVerbs("POST")]
        public string Post([FromBody] string FacebookFeedPost)
        {
            return MyFB.FacebookFeedPost(FacebookFeedPost);

        }

//        // GET: api/Engine/5
//        public string Get(int id)
//        {
//            return "value";
//        }

//        // PUT: api/Engine/5
//        public void Put(int id, [FromBody]string value)
//        {
//        }

//        // DELETE: api/Engine/5
//        public void Delete(int id)
//        {
//        }
    }
}
