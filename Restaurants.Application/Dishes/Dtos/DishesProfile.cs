using AutoMapper;
using Restaurants.Domain.Entities;

namespace Restaurants.Application.Dishes.Dtos
{
    public class DishesProfile : Profile
    {
        public DishesProfile()
        {
            CreateMap<Dish, DishDto>();
        }
    }
}
