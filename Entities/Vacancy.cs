using Entities.Enums;

namespace Entities
{
    public class Vacancy
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public City City { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string Salary { get; set; }
        public Employement Employement { get; set; }
        public WorkingDays WorkingDays { get; set; }
        public WorkingHours WorkingHours { get; set; }
        public string Phone { get; set; } 

        public DateTime CreationDate { get; set; }
        public DateTime? EditDate { get; set; }
    }
}
