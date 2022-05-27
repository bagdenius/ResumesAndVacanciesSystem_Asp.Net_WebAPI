using AutoMapper;
using MediatR;
using UnitOfWork.Abstract;
using ViewModels;

namespace CommandsAndQueries.UserQueries.GetUserList
{
    public class GetUserListQueryHandler : IRequestHandler<GetUserListQuery, List<UserVM>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetUserListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) =>
            (_unitOfWork, _mapper) = (unitOfWork, mapper);

        public async Task<List<UserVM>> Handle(GetUserListQuery request, CancellationToken cancellationToken)
        {
            var users = await _unitOfWork.Users.GetAllAsync(cancellationToken);
            return _mapper.Map<List<UserVM>>(users);
        }
    }
}
