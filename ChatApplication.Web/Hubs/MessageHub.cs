using ChatApplication.Web.Models.ApplicationConstants;
using ChatApplication.Web.Redis;
using EntityLibrary.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApplication.Web.Hubs
{
    public class MessageHub : Hub
    {
        public static ConcurrentDictionary<string, long> ConnectUserList = new();
        IHttpContextAccessor _httpContextAccessor;
        private readonly ChatprojectdbContext _context;
        private readonly RedisManager _redisManager;

        public MessageHub(IHttpContextAccessor httpContextAccessor, ChatprojectdbContext context, RedisManager redisManager)
        {
            this._httpContextAccessor = httpContextAccessor;
            _context = context;
            _redisManager = redisManager;
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
        public override Task OnConnectedAsync()
        {
            User user = GetCurrentMember();
            ConnectUserList.TryAdd(Context.ConnectionId, user.Id);
            return base.OnConnectedAsync();
        }
        public async Task GetMessage(long releatedUserId)
        {
            User user = GetCurrentMember();
            List<Message> messages = _context.Messages.Where(x => (x.RecipientUserId == user.Id && x.SenderUserId==releatedUserId)||(x.RecipientUserId==releatedUserId && x.SenderUserId==user.Id)).ToList();
            List<string> connectionIdList = ConnectUserList.Keys.ToList();
            await Clients.Clients(connectionIdList).SendAsync("Messages",messages);
        }
    }
}
