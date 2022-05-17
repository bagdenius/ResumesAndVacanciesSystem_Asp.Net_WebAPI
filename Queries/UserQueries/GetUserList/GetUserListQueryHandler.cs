using AutoMapper;
using Domain;
using MediatR;
using Services.Abstract;
using ViewModels;

namespace Queries.UserQueries.GetUserList
{
    public class GetUserListQueryHandler : IRequestHandler<GetUserListQuery, List<UserVM>>
    {
        private readonly IService<User> _service;
        private readonly IMapper _mapper;
        public GetUserListQueryHandler(IService<User> service, IMapper mapper) =>
            (_service, _mapper) = (service, mapper);

        public async Task<List<UserVM>> Handle(GetUserListQuery request, CancellationToken cancellationToken)
        {
            var users = _mapper.Map<List<UserVM>>(_service.GetAll());
            return users;
        }
    }
}
