using MediatR;
using ViewModels;

namespace Queries.VacancyQueries.GetVacancy
{
    public class GetVacancyQuery : IRequest<VacancyVM>
    {
        public Guid Id { get; set; }
    }
}
