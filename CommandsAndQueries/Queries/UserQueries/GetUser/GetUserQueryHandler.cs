using AutoMapper;
using MediatR;
using CommandsAndQueries.Exceptions;
using UnitOfWork.Abstract;
using Entities;
using ViewModels;

namespace CommandsAndQueries.UserQueries.GetUser
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserVM>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetUserQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) =>
            (_unitOfWork, _mapper) = (unitOfWork, mapper);

        public async Task<UserVM> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _unitOfWork.Users.GetAsync(request.Id, cancellationToken);
            if (user == null || user.Id != request.Id)
                throw new NotFoundException(nameof(User), request.Id);
            return _mapper.Map<UserVM>(user);
        }
    }
}
