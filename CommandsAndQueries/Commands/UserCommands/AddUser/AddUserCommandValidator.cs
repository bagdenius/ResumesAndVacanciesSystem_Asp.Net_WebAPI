using FluentValidation;
using CommandsAndQueries.UserCommands.AddUser;
using Entities.Enums;

namespace Commands.UserCommands.CreateUser
{
    public class AddUserCommandValidator : AbstractValidator<AddUserCommand>
    {
        public AddUserCommandValidator()
        {
            RuleFor(createUserCommand =>
                createUserCommand.Name).NotEmpty().MaximumLength(23);

            RuleFor(createUserCommand =>
                createUserCommand.Surname).NotEmpty().MaximumLength(23);

            RuleFor(createUserCommand =>
                createUserCommand.Patronymic).NotEmpty().MaximumLength(23);

            RuleFor(createUserCommand =>
                createUserCommand.Education).IsInEnum();

            RuleFor(createUserCommand =>
                createUserCommand.Gender).IsInEnum();

            RuleFor(createUserCommand =>
                createUserCommand.BirthDate).NotEmpty();

            RuleFor(createUserCommand =>
                createUserCommand.Role).IsInEnum();

            RuleFor(createUserCommand =>
                createUserCommand.City).IsInEnum();

            RuleFor(createUserCommand =>
                createUserCommand.Phone).NotEmpty().MaximumLength(20);

            RuleFor(createUserCommand =>
                createUserCommand.Email).NotEmpty().EmailAddress();
        }
    }
}
