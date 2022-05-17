namespace Entities
{
    public class UserEntity
    {
        public Guid Id { get; set; }
        public List<ResumeEntity> Resumes { get; set; }
        public List<VacancyEntity> Vacancies { get; set; }
        
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
