using Entities.Enums;

namespace Entities
{
    public class Resume
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }

        public string Title { get; set; }
        public string Position { get; set; }
        public string Salary { get; set; }
        public Employement Employement { get; set; }
        public string Content { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime? EditDate { get; set; }
    }
}
