using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Restaurants.Domain.Constants;
using Restaurants.Domain.Entities;
using Restaurants.Domain.Exceptions;
using Restaurants.Domain.Interfaces;
using Restaurants.Domain.Repositories;

namespace Restaurants.Application.Dishes.Commands.CreateDish;

public class BulkCreateDishesCommandHandler(
    ILogger<BulkCreateDishesCommandHandler> logger,
    IRestaurantsRepository restaurantsRepository,
    IDishesRepository dishesRepository,
    IMapper mapper,
    IRestaurantAuthorizationService restaurantAuthorizationService)
    : IRequestHandler<BulkCreateDishesCommand, IList<int>>
{
    public async Task<IList<int>> Handle(BulkCreateDishesCommand request, CancellationToken cancellationToken)
    {
        logger.LogInformation("Bulk creating dishes: {@BulkDishRequest}", request);
        var restaurant = await restaurantsRepository.GetByIdAsync(request.RestaurantId);
        if (restaurant == null)
            throw new NotFoundException(nameof(Restaurant), request.RestaurantId.ToString());

        if (!restaurantAuthorizationService.Authorize(restaurant, ResourceOperation.Update))
            throw new ForbidException();

        var dishIds = new List<int>();
        foreach (var dishCommand in request.Dishes)
        {
            dishCommand.RestaurantId = request.RestaurantId;
            var dish = mapper.Map<Dish>(dishCommand);
            var id = await dishesRepository.Create(dish);
            dishIds.Add(id);
        }
        return dishIds;
    }
}
