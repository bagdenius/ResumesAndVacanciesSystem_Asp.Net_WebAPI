using AutoMapper;
using CommandsAndQueries.UserCommands.AddUser;
using CommandsAndQueries.UserCommands.RemoveUser;
using CommandsAndQueries.UserCommands.UpdateUser;
using CommandsAndQueries.UserQueries.GetUser;
using CommandsAndQueries.UserQueries.GetUserList;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using UI.Models.User;
using ViewModels;

namespace UI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : BaseController
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public UserController(IMediator mediator, IMapper mapper) =>
            (_mediator, _mapper) = (mediator, mapper);

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
        public async Task<ActionResult<Guid>> Create(AddUserModel addUserModel)
        {
            var command = _mapper.Map<AddUserCommand>(addUserModel);
            var userId = await _mediator.Send(command);
            return Ok(userId);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateUserModel updateUserCommand)
        {
            var command = _mapper.Map<UpdateUserCommand>(updateUserCommand);
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
