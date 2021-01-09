using Basket.API.Entities;
using System;
using System.Threading.Tasks;

namespace Basket.API.Repositories.Interfaces
{
    [Obsolete("Should use more generic data inteface, not 'Redis'")]
    public interface IBasketRepository
    {
        Task<BasketCart> GetBasket(string userName);
        Task<BasketCart> UpdateBasket(BasketCart basket);
        Task<bool> DeleteBasket(string userName);
    }
}
