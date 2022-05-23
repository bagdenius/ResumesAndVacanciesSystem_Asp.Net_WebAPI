using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class DbContextOptionsFactory
    {
        public static DbContextOptions<DatabaseContext> Get()
        {
            var builder = new DbContextOptionsBuilder<DatabaseContext>();
            builder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ResumesAndVacancies");
            return builder.Options;
        }
    }
}
