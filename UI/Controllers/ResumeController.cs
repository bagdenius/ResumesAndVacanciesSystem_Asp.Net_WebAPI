using AutoMapper;
using CommandsAndQueries.ResumeCommands.AddResume;
using CommandsAndQueries.ResumeCommands.RemoveResume;
using CommandsAndQueries.ResumeCommands.UpdateResume;
using CommandsAndQueries.ResumeQueries.GetResume;
using CommandsAndQueries.ResumeQueries.GetResumeList;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using UI.Models.Resume;
using ViewModels;

namespace UI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResumeController : BaseController
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public ResumeController(IMediator mediator, IMapper mapper) =>
            (_mediator, _mapper) = (mediator, mapper);

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
        public async Task<ActionResult<Guid>> Create(AddResumeModel addResumeModel)
        {
            var command = _mapper.Map<AddResumeCommand>(addResumeModel);
            var resumeId = await _mediator.Send(command);
            return Ok(resumeId);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateResumeModel updateResumeModel)
        {
            var command = _mapper.Map<UpdateResumeCommand>(updateResumeModel);
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
