using FluentValidation;

namespace Restaurants.Application.Dishes.Commands.CreateDish
{
    public class CreateDishCommandValidator : AbstractValidator<CreateDishCommand>
    {
        public CreateDishCommandValidator()
        {
            RuleFor(dish => dish.Price)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Price must be a non-negative number.");


            RuleFor(dish => dish.KiloCalories)
                .GreaterThanOrEqualTo(0)
                .WithMessage("KiloCalories must be a non-negative number.");
        }
    }
}
