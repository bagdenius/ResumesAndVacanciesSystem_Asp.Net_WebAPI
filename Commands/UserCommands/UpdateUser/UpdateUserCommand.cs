using MediatR;

namespace Queries.UserCommands.UpdateUser
{
    public class UpdateUserCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Education { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Role { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
