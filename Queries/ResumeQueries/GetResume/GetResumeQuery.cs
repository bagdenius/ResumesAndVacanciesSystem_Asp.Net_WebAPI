using MediatR;
using ViewModels;

namespace Queries.ResumeQueries.GetResume
{
    public class GetResumeQuery : IRequest<ResumeVM>
    {
        public Guid Id { get; set; }
    }
}
