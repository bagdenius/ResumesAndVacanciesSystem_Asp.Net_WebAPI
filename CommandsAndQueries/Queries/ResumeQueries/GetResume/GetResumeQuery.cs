using MediatR;
using ViewModels;

namespace CommandsAndQueries.ResumeQueries.GetResume
{
    public class GetResumeQuery : IRequest<ResumeVM>
    {
        public Guid Id { get; set; }
    }
}
