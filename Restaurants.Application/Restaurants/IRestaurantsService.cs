using Restaurants.Domain.Entities;

namespace Restaurants.Application.Restaurants
{
    public interface IRestaurantsService
    {
        Task<IEnumerable<Restaurant>> GetAllRestaurants();
    }
}