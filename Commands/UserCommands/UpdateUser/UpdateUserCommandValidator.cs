using FluentValidation;
using Queries.UserCommands.UpdateUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.UserCommands.UpdateUser
{
    public class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
    {
        public UpdateUserCommandValidator()
        {
            RuleFor(createUserCommand =>
                createUserCommand.Id).NotEqual(Guid.Empty);
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
