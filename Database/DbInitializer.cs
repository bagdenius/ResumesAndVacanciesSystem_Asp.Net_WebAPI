namespace Database
{
    public class DbInitializer
    {
        public static void initialize(DatabaseContext context)
        {
            //context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}
