using AutoMapper;
using Domain;
using MediatR;
using Services.Abstract;
using ViewModels;

namespace Queries.ResumeQueries.GetResumeList
{
    public class GetResumeListQueryHandler : IRequestHandler<GetResumeListQuery, List<ResumeVM>>
    {
        private readonly IService<Resume> _service;
        private readonly IMapper _mapper;
        public GetResumeListQueryHandler(IService<Resume> service, IMapper mapper) =>
            (_service, _mapper) = (service, mapper);

        public async Task<List<ResumeVM>> Handle(GetResumeListQuery request, CancellationToken cancellationToken)
        {
            var users = await _service.GetAllAsync(cancellationToken);
            return _mapper.Map<List<ResumeVM>>(users);
        }
    }
}
