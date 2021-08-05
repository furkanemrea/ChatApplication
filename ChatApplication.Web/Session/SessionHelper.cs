using ChatApplication.Web.Models.ApplicationConstants;
using EntityLibrary.Entity;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApplication.Web.Session
{
    public class SessionHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public SessionHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public User GetCurrentUser()
        {
            string cookieSerializeString = _httpContextAccessor.HttpContext.Request.Cookies[CookieConstants.CurrentUserName];
            User user =JsonConvert.DeserializeObject<User>(cookieSerializeString);
            return user;
        }
    }
}
