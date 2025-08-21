using FluentValidation;

namespace Restaurants.Application.Dishes.Commands.CreateDish;

public class BulkCreateDishesCommandValidator : AbstractValidator<BulkCreateDishesCommand>
{
    public BulkCreateDishesCommandValidator()
    {
        RuleForEach(x => x.Dishes).SetValidator(new CreateDishCommandValidator());
    }
}
