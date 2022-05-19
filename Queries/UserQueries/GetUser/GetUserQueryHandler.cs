using AutoMapper;
using Domain;
using MediatR;
using Queries.Exceptions;
using Services.Abstract;
using ViewModels;

namespace Queries.UserQueries.GetUser
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserVM>
    {
        private readonly IService<User> _service;
        private readonly IMapper _mapper;
        public GetUserQueryHandler(IService<User> service, IMapper mapper) =>
            (_service, _mapper) = (service, mapper);

        public async Task<UserVM> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _service.GetAsync(request.Id, cancellationToken);
            if (user == null || user.Id != request.Id)
                throw new NotFoundException(nameof(User), request.Id);
            return _mapper.Map<UserVM>(user);
        }
    }
}
