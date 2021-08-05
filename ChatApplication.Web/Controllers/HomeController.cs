using ChatApplication.Web.Models;
using ChatApplication.Web.Models.ApplicationConstants;
using EntityLibrary.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApplication.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ChatprojectdbContext _chatprojectdbContext;
        IHttpContextAccessor _httpContextAccessor;

        public HomeController(ILogger<HomeController> logger, ChatprojectdbContext chatprojectdbContext, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _chatprojectdbContext = chatprojectdbContext;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index(long userId)
        {
            return View(userId);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public User GetCurrentMember()
        {
            try
            {
                string cookieValue = _httpContextAccessor.HttpContext.Request.Cookies[CookieConstants.CurrentUserName];
                User user = JsonConvert.DeserializeObject<User>(cookieValue);
                return user;
            }

            catch (Exception ex)
            {
                return null;

            }
        }
        public IActionResult LoginPage()
        {
            return View();
        }
     
        public IActionResult UserList()
        {
            User user = GetCurrentMember();
            return View(_chatprojectdbContext.Users.Where(x => x.Id != user.Id).ToList());
        }
        public int Login(string password, string mailAddress)
        {
            try
            {
                User user = _chatprojectdbContext.Users.Where(x => x.Password == password && x.Mail == mailAddress).FirstOrDefault();
                if (user is not null)
                {
                    string cookieSet = JsonConvert.SerializeObject(user);
                    CookieOptions option = new CookieOptions();
                    option.Expires = DateTime.Now.AddDays(3);
                    _httpContextAccessor.HttpContext.Response.Cookies.Append(CookieConstants.CurrentUserName, cookieSet, option);
                    return 1;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }

            return 0;
        }
        public int SendMessage(string messageText,long userId) 
        {
            Message message = new Message();
            message.RecipientUserId = userId;
            message.SenderUserId = GetCurrentMember().Id;
            message.MessageText = messageText;
            message.SendDate = DateTime.Now;
            _chatprojectdbContext.Messages.Add(message);
            _chatprojectdbContext.SaveChanges();

            return 1;
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
