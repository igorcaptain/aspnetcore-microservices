using Basket.API.Data.Interfaces;
using Basket.API.Entities;
using Basket.API.Repositories.Interfaces;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace Basket.API.Repositories
{
    [Obsolete("Should use more generic data inteface, not 'Redis'")]
    public class BasketRepository : IBasketRepository
    {
        private readonly IBasketContext _context;

        public BasketRepository(IBasketContext context)
        {
            _context = context;
        }

        public async Task<BasketCart> GetBasket(string userName)
        {
            var basket = await _context.Redis
                .StringGetAsync(userName);
            return basket.IsNullOrEmpty ? null : JsonSerializer.Deserialize<BasketCart>(basket);
        }

        public async Task<BasketCart> UpdateBasket(BasketCart basket)
        {
            var updated = await _context.Redis
                .StringSetAsync(basket.UserName, JsonSerializer.Serialize(basket));
            return updated ? await GetBasket(basket.UserName) : null;
        }

        public async Task<bool> DeleteBasket(string userName)
        {
            return await _context.Redis
                .KeyDeleteAsync(userName);
        }
    }
}
