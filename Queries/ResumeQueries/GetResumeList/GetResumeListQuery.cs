using MediatR;
using ViewModels;

namespace Queries.ResumeQueries.GetResumeList
{
    public class GetResumeListQuery : IRequest<List<ResumeVM>>
    {

    }
}
