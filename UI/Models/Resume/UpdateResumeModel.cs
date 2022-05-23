namespace UI.Models.Resume
{
    public class UpdateResumeModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public string Employement { get; set; }
        public int Experience { get; set; }
        public string Content { get; set; }
    }
}
