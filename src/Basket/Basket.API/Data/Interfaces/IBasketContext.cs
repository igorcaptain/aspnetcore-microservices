using StackExchange.Redis;
using System;

namespace Basket.API.Data.Interfaces
{
    [Obsolete("Should use more generic data inteface, not 'Redis'")]
    public interface IBasketContext
    {
        IDatabase Redis { get; }
    }
}
