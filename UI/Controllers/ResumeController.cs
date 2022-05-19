using MediatR;
using Microsoft.AspNetCore.Mvc;
using Queries.ResumeCommands.CreateResume;
using Queries.ResumeCommands.RemoveResume;
using Queries.ResumeCommands.UpdateResume;
using Queries.ResumeQueries.GetResume;
using Queries.ResumeQueries.GetResumeList;
using ViewModels;

namespace UI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResumeController : BaseController
    {
        private readonly IMediator _mediator;
        public ResumeController(IMediator mediator) =>
            _mediator = mediator;

        [HttpGet]
        public async Task<ActionResult<List<ResumeVM>>> GetAll()
        {
            var query = new GetResumeListQuery { };
            var vm = await _mediator.Send(query);
            return Ok(vm);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserVM>> Get(Guid id)
        {
            var query = new GetResumeQuery { Id = id };
            var vm = await _mediator.Send(query);
            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create(ResumeVM resume)
        {
            var command = new CreateResumeCommand
            {
                UserId = resume.Id,
                Title = resume.Title,
                City = resume.City,
                Position = resume.Position,
                Salary = resume.Salary,
                Employement = resume.Employement,
                Experience = resume.Experience,
                Content = resume.Content
            };
            var resumeId = await _mediator.Send(command);
            return Ok(resumeId);
        }

        [HttpPut]
        public async Task<IActionResult> Update(ResumeVM resume)
        {
            var command = new UpdateResumeCommand
            {
                Id = resume.Id,
                UserId = resume.UserId,
                Title = resume.Title,
                City = resume.City,
                Position = resume.Position,
                Salary = resume.Salary,
                Employement = resume.Employement,
                Experience = resume.Experience,
                Content = resume.Content
            };
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var command = new RemoveResumeCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
