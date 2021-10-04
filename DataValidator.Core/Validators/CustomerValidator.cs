using DataValidator.Data.CriticalValues;
using DataValidator.Data.Models;
using FluentValidation;
namespace DataValidator.Core.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(customer => IsIdValid(customer.Id))
                .NotNull()
                .NotEmpty()
                .WithMessage("Id is not valid");
            RuleFor(customer => IsAgeValid(customer.Age))
                .NotNull()
                .NotEmpty()
                .WithMessage("Age is not valid");
            RuleFor(customer => IsGenreValid(customer.Genre))
                .NotNull()
                .NotEmpty()
                .WithMessage("Genre is not valid");
            RuleFor(customer => IsIncomeValid(customer.Income))
                .NotNull()
                .NotEmpty()
                .WithMessage("Income is not valid");
            RuleFor(customer => IsScoreValid(customer.Score))
                .NotNull()
                .NotEmpty()
                .WithMessage("Score is not valid");

        }
        public bool IsIdValid(int id)
        {
            return id > 0;
        }

        public bool IsGenreValid(string genre)
        {
            return !CustomerCriticalValues.Genre.Contains(genre);
        }
        public bool IsAgeValid(int age)
        {
            return age > 0;
        }

        public bool IsIncomeValid(int income)
        {
            return income > 0;
        }
        public bool IsScoreValid(int spendingScore)
        {
            return spendingScore > 0;
        }
    }
}