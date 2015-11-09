using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Caching;
using System.Web.Http;

namespace Week3Lab.Controllers
{
    public class SlackerController : ApiController
    {
        List<Post> posts = new List<Post>
        {
            new Post { Id = 1,UserName = "Josh" , Body = "Blah1" },
            
        };

        public List<Post> GetAllPost() // to return all post.
        {
            return posts;
        }

        public Post createPost(Post newpost) // creates a post.
        {

            newpost.Id = 7;
            posts.Add(newpost);
            return newpost;
        }



        //private List<Post> GetPosts()
        //{
        //    //Retrieve out of the cache the current posts.
        //    MemoryCache memoryCache = MemoryCache.Default;
        //    var posts = (List<Post>)memoryCache.Get("old");

        //    if (posts == null)
        //    {
        //        posts = new List<Post>();
        //        memoryCache.Set("old", posts, DateTimeOffset.Now.AddHours(24));
        //    }

        //    return posts;
        //}
        //private void SavePosts(List<Post> posts)
        //{
        //    //put the list of posts back in to the cache.
        //    MemoryCache memoryCache = MemoryCache.Default;
        //    memoryCache.Set("new", posts, DateTimeOffset.Now.AddHours(24));

    }
    }
}
