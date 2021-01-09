using Basket.API.Data.Interfaces;
using StackExchange.Redis;
using System;

namespace Basket.API.Data
{
    [Obsolete("Should use more generic data inteface, not 'Redis'")]
    public class BasketContext : IBasketContext
    {
        private readonly ConnectionMultiplexer _redisConnection;

        public BasketContext(ConnectionMultiplexer redisConnection)
        {
            _redisConnection = redisConnection;
            Redis = _redisConnection.GetDatabase();
        }

        public IDatabase Redis { get; }
    }
}
