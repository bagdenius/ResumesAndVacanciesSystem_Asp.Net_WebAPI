using Entities.Enums;

namespace Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public List<Resume> Resumes { get; set; }
        public List<Vacancy> Vacancies { get; set; }

        // Account
        public string Login { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }


        // Profile
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public Education Education { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public City City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
