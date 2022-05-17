namespace Database
{
    public class DbInitializer
    {
        public static void Initialize(DatabaseContext context)
        {
            //context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}
