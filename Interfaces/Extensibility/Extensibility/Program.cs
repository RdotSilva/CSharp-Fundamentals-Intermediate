namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("C:\\test\\test2.txt"));
            dbMigrator.Migrate();
            
        }
    }
}
