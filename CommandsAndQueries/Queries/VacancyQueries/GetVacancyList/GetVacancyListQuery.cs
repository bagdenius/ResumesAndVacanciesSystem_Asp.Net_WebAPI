using MediatR;
using ViewModels;

namespace CommandsAndQueries.VacancyQueries.GetVacancyList
{
    public class GetVacancyListQuery : IRequest<List<VacancyVM>>
    {

    }
}
