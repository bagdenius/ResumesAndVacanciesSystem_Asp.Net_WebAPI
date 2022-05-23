using MediatR;
using ViewModels;

namespace CommandsAndQueries.VacancyQueries.GetVacancy
{
    public class GetVacancyQuery : IRequest<VacancyVM>
    {
        public Guid Id { get; set; }
    }
}
