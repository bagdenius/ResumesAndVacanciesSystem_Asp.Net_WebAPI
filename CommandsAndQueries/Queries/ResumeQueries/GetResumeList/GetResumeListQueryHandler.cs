using AutoMapper;
using MediatR;
using UnitOfWork.Abstract;
using ViewModels;

namespace CommandsAndQueries.ResumeQueries.GetResumeList
{
    public class GetResumeListQueryHandler : IRequestHandler<GetResumeListQuery, List<ResumeVM>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetResumeListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) =>
            (_unitOfWork, _mapper) = (unitOfWork, mapper);

        public async Task<List<ResumeVM>> Handle(GetResumeListQuery request, CancellationToken cancellationToken)
        {
            var users = await _unitOfWork.Resumes.GetAllAsync(cancellationToken);
            return _mapper.Map<List<ResumeVM>>(users);
        }
    }
}
