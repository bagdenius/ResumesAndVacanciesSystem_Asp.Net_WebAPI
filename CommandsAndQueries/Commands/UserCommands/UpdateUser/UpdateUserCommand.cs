using Entities;
using Entities.Enums;
using MediatR;

namespace CommandsAndQueries.UserCommands.UpdateUser
{
    public class UpdateUserCommand : IRequest
    {
        // Account
        public string Login { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }


        // Profile
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public Education Education { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public City City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
