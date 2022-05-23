namespace Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public List<Resume> Resumes { get; set; }
        public List<Vacancy> Vacancies { get; set; }
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Education { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Role { get; set; } // admin employee recruiter
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
