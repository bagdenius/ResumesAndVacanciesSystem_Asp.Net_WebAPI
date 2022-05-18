using MediatR;
using ViewModels;

namespace Queries.VacancyQueries.GetVacancyList
{
    public class GetVacancyListQuery : IRequest<List<VacancyVM>>
    {

    }
}
