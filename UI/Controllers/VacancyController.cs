using MediatR;
using Microsoft.AspNetCore.Mvc;
using Queries.VacancyCommands.CreateVacancy;
using Queries.VacancyCommands.RemoveVacancy;
using Queries.VacancyCommands.UpdateVacancy;
using Queries.VacancyQueries.GetVacancy;
using Queries.VacancyQueries.GetVacancyList;
using ViewModels;

namespace UI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VacancyController : BaseController
    {
        private readonly IMediator _mediator;
        public VacancyController(IMediator mediator) =>
            _mediator = mediator;

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
        public async Task<ActionResult<Guid>> Create(VacancyVM vacancy)
        {
            var command = new CreateVacancyCommand
            {
                UserId = vacancy.UserId,
                Title = vacancy.Title,
                Description = vacancy.Description,
                City = vacancy.City,
                Company = vacancy.Company,
                Position = vacancy.Position,
                Salary = vacancy.Salary,
                Employement = vacancy.Employement,
                WorkingDays = vacancy.WorkingDays,
                WorkingHours = vacancy.WorkingHours,
                Experience = vacancy.Experience,
                Phone = vacancy.Phone
            };
            var vacancyId = await _mediator.Send(command);
            return Ok(vacancyId);
        }

        [HttpPut]
        public async Task<IActionResult> Update(VacancyVM vacancy)
        {
            var command = new UpdateVacancyCommand
            {
                Id = vacancy.Id,
                UserId = vacancy.UserId,
                Title = vacancy.Title,
                Description = vacancy.Description,
                City = vacancy.City,
                Company = vacancy.Company,
                Position = vacancy.Position,
                Salary = vacancy.Salary,
                Employement = vacancy.Employement,
                WorkingDays = vacancy.WorkingDays,
                WorkingHours = vacancy.WorkingHours,
                Experience = vacancy.Experience,
                Phone = vacancy.Phone
            };
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
