using FluentValidation;
using CommandsAndQueries.UserCommands.AddUser;

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
                createUserCommand.Education).NotEmpty().MaximumLength(20);
            RuleFor(createUserCommand =>
                createUserCommand.Gender).NotEmpty().MaximumLength(10);
            RuleFor(createUserCommand =>
                createUserCommand.BirthDate).NotEmpty();
            RuleFor(createUserCommand =>
                createUserCommand.Role).NotEmpty().MaximumLength(20);
            RuleFor(createUserCommand =>
                createUserCommand.City).NotEmpty().MaximumLength(40);
            RuleFor(createUserCommand =>
                createUserCommand.Phone).NotEmpty().MaximumLength(20);
            RuleFor(createUserCommand =>
                createUserCommand.Email).NotEmpty().EmailAddress();
        }
    }
}
