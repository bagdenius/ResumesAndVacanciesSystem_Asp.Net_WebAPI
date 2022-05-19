using AutoMapper;
using Queries.Exceptions;
using Domain;
using MediatR;
using Services.Abstract;

namespace Queries.ResumeCommands.RemoveResume
{
    public class RemoveResumeCommandHandler : IRequestHandler<RemoveResumeCommand>
    {
        private readonly IService<Resume> _service;
        private readonly IMapper _mapper;
        public RemoveResumeCommandHandler(IService<Resume> service, IMapper mapper) =>
            (_service, _mapper) = (service, mapper);

        public async Task<Unit> Handle(RemoveResumeCommand request, CancellationToken cancellationToken)
        {
            var resume = await _service.GetAsync(request.Id, cancellationToken);
            if (resume == null || resume.Id != request.Id)
                throw new NotFoundException(nameof(Resume), request.Id);
            _service.Remove(resume.Id);
            await _service.SaveAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
