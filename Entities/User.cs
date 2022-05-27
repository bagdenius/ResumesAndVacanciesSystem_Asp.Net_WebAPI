using Entities.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class User : IdentityUser<Guid>
    {
        public List<Resume> Resumes { get; set; }
        public List<Vacancy> Vacancies { get; set; }

        // Account
        //public string Login { get; set; }
        //public string Password { get; set; }
        //public Role Role { get; set; }


        // Profile
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public Education Education { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public City City { get; set; }

        //public DateTime CreationDate { get; set; }
    }
}
