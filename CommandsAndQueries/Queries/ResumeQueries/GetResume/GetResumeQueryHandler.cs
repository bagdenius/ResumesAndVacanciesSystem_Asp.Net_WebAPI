using MediatR;
using CommandsAndQueries.Exceptions;
using ViewModels;
using UnitOfWOrk.Abstract;
using Entities;
using AutoMapper;

namespace CommandsAndQueries.ResumeQueries.GetResume
{
    public class GetResumeQueryHandler : IRequestHandler<GetResumeQuery, ResumeVM>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetResumeQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) =>
            (_unitOfWork, _mapper) = (unitOfWork, mapper);

        public async Task<ResumeVM> Handle(GetResumeQuery request, CancellationToken cancellationToken)
        {
            var resume = await _unitOfWork.Resumes.GetAsync(request.Id, cancellationToken);
            if (resume == null || resume.Id != request.Id)
                throw new NotFoundException(nameof(Resume), request.Id);
            return _mapper.Map<ResumeVM>(resume);
        }
    }
}
