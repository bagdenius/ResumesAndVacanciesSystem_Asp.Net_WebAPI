using Queries.UserCommands.CreateUser;
using Queries.UserCommands.RemoveUser;
using Queries.UserCommands.UpdateUser;
using Queries.UserQueries.GetUser;
using Queries.UserQueries.GetUserList;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViewModels;

namespace UI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : BaseController
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator) =>
            _mediator = mediator;

        [HttpGet]
        public async Task<ActionResult<List<UserVM>>> GetAll()
        {
            var query = new GetUserListQuery { };
            var vm  = await _mediator.Send(query);
            return Ok(vm);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserVM>> Get(Guid id)
        {
            var query = new GetUserQuery { Id = id };
            var vm = await _mediator.Send(query);
            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create(UserVM user)
        {
            var command = new CreateUserCommand
            {
                Name = user.Name,
                Surname = user.Surname,
                Patronymic = user.Patronymic,
                Education = user.Education,
                Gender = user.Gender,
                BirthDate = user.BirthDate,
                Role = user.Role,
                City = user.City,
                Phone = user.Phone,
                Email = user.Email
            };
            var userId = await _mediator.Send(command);
            return Ok(userId);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UserVM user)
        {
            var command = new UpdateUserCommand
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Patronymic = user.Patronymic,
                Education = user.Education,
                Gender = user.Gender,
                BirthDate = user.BirthDate,
                Role = user.Role,
                City = user.City,
                Phone = user.Phone,
                Email = user.Email
            };
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var command = new RemoveUserCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
