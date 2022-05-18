﻿using MediatR;

namespace Commands.ResumeCommands.CreateResume
{
    public class CreateResumeCommand : IRequest<Guid>
    {
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public string Position { get; set; }
        public string Salary { get; set; }
        public string Employement { get; set; }
        public int Experience { get; set; }
        public string Content { get; set; }
    }
}