using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Caching;
using System.Web.Http;
using System.Web.Services.Description;

namespace Week3Lab.Controllers
{
    public class SlackerController : ApiController
    {
        private List<Message> GetMessages()
        {
            //Retrieve out of the cache the current posts.
            MemoryCache memoryCache = MemoryCache.Default;
            var messages = (List<Message>)memoryCache.Get("messages");

            if (messages == null)
            {
                messages = new List<Message>();
                memoryCache.Set("messages", messages, DateTimeOffset.Now.AddSeconds(10));
            }

            return messages;
        }
        private void SaveMessages(List<Message> messages)
        {
            //put the list of posts back in to the cache.
            MemoryCache memoryCache = MemoryCache.Default;
            memoryCache.Set("messages", messages, DateTimeOffset.Now.AddHours(24));

        }


        public IHttpActionResult GetAllMessage()
        {
            return Ok(GetMessages());
        }

        public IHttpActionResult CreateMessage(Message msg)
        {
            var currentAllMessage = GetMessages();
            if (currentAllMessage.Any())
            {
                msg.Id = currentAllMessage.Max(x => x.Id) + 1;
            }
            else
            {
                msg.Id = 1;
            }
            currentAllMessage.Add(msg);
            SaveMessages(currentAllMessage);
            return Ok(msg);
        }

    }
}


