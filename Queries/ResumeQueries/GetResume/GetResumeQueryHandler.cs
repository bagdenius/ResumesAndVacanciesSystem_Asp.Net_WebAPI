using AutoMapper;
using Domain;
using MediatR;
using Queries.Exceptions;
using Services.Abstract;
using ViewModels;

namespace Queries.ResumeQueries.GetResume
{
    public class GetResumeQueryHandler : IRequestHandler<GetResumeQuery, ResumeVM>
    {
        private readonly IService<Resume> _service;
        private readonly IMapper _mapper;
        public GetResumeQueryHandler(IService<Resume> service, IMapper mapper) =>
            (_service, _mapper) = (service, mapper);

        public async Task<ResumeVM> Handle(GetResumeQuery request, CancellationToken cancellationToken)
        {
            var resume = await _service.GetAsync(request.Id, cancellationToken);
            if (resume == null || resume.Id != request.Id)
                throw new NotFoundException(nameof(Resume), request.Id);
            return _mapper.Map<ResumeVM>(resume);
        }
    }
}
