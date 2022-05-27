using AutoMapper;
using CommandsAndQueries.VacancyCommands.AddVacancy;
using CommandsAndQueries.VacancyCommands.RemoveVacancy;
using CommandsAndQueries.VacancyCommands.UpdateVacancy;
using CommandsAndQueries.VacancyQueries.GetVacancy;
using CommandsAndQueries.VacancyQueries.GetVacancyList;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using UI.Models.Vacancy;
using ViewModels;

namespace UI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VacancyController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public VacancyController(IMediator mediator, IMapper mapper) =>
            (_mediator, _mapper) = (mediator, mapper);

        [HttpGet]
        public async Task<ActionResult<List<VacancyVM>>> GetAll()
        {
            var query = new GetVacancyListQuery { };
            var vm = await _mediator.Send(query);
            return Ok(vm);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<VacancyVM>> Get(Guid id)
        {
            var query = new GetVacancyQuery { Id = id };
            var vm = await _mediator.Send(query);
            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Add(AddVacancyModel addVacancyModel)
        {
            var command = _mapper.Map<AddVacancyCommand>(addVacancyModel);
            var vacancyId = await _mediator.Send(command);
            return Ok(vacancyId);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateVacancyModel updateVacancyModel)
        {
            var command = _mapper.Map<UpdateVacancyCommand>(updateVacancyModel);
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var command = new RemoveVacancyCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
