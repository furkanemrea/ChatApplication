using Microsoft.Extensions.Configuration;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApplication.Web.Redis
{
    public class RedisManager
    {
        private readonly string _redisHost;
        private readonly string _redisPort;
        public ConnectionMultiplexer _redis;
        public IDatabase db { get; set; }
        public RedisManager(IConfiguration configuration)
        {
            _redisHost = configuration["Redis:Host"];
            _redisPort = configuration["Redis:Port"];
        }
        public void Connect()
        {
            var configString = $"{_redisHost}:{_redisPort}";
            _redis = ConnectionMultiplexer.Connect(configString);
        }
        public IDatabase GetDb(int db=1)
        {
            return _redis.GetDatabase(db);
        }
    }
}
