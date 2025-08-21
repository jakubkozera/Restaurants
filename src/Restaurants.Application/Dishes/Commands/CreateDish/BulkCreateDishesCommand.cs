using MediatR;
using System.Collections.Generic;

namespace Restaurants.Application.Dishes.Commands.CreateDish;

public class BulkCreateDishesCommand : IRequest<IList<int>>
{
    public int RestaurantId { get; set; }
    public List<CreateDishCommand> Dishes { get; set; } = new();
}
