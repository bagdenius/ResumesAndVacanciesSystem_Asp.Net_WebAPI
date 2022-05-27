using Entities.Enums;

namespace ViewModels
{
    public class ResumeVM
    {
        public Guid Id { get; set; }
        //public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Position { get; set; }
        public string Salary { get; set; }
        public Employement Employement { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EditDate { get; set; }
        public UserVM User { get; set; }
    }
}
