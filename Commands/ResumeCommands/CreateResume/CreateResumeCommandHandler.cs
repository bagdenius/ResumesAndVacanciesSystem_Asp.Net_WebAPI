using AutoMapper;
using Domain;
using MediatR;
using Services.Abstract;
using ViewModels;

namespace Queries.ResumeCommands.CreateResume
{
    public class CreateResumeCommandHandler : IRequestHandler<CreateResumeCommand, Guid>
    {
        private readonly IService<Resume> _service;
        private readonly IMapper _mapper;
        public CreateResumeCommandHandler(IService<Resume> service, IMapper mapper) =>
            (_service, _mapper) = (service, mapper);

        public async Task<Guid> Handle(CreateResumeCommand request, CancellationToken cancellationToken)
        {
            var resume = new ResumeVM
            {
                Id = Guid.NewGuid(),
                Title = request.Title,
                City = request.City,
                Position = request.Position,
                Salary = request.Salary,
                Employement = request.Employement,
                Experience = request.Experience,
                Content = request.Content,
                CreationDate = DateTime.Now
            };
            await _service.AddAsync(_mapper.Map<Resume>(resume), cancellationToken);
            await _service.SaveAsync(cancellationToken);
            return resume.Id;
        }
    }
}
