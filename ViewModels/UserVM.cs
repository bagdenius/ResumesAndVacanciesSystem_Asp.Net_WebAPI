using Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace ViewModels
{
    public class UserVM
    {
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
        public DateTime CreationDate { get; set; }
        public List<ResumeVM> Resumes { get; set; }
        public List<VacancyVM> Vacancies { get; set; }
    }
}
