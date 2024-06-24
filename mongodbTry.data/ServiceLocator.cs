using MongoDB.Driver;

namespace mongodbTry.data
{
    public static class ServiceLocator
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static void SetServiceProvider(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }

        //public static void connectDb()
        //{

        //      string connectionString = "mongodb+srv://huda:fts2024@cluster0.oup1m9x.mongodb.net/";  
        //    //string connectionString = "mongodb://localhost:27017";
        //    MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(connectionString));
        //    settings.ConnectTimeout = TimeSpan.FromSeconds(30);
        //    settings.ServerSelectionTimeout = TimeSpan.FromSeconds(30);
        //    MongoClient client = new MongoClient(settings);
        //    //MongoClient client = new MongoClient(connectionString);
        //    try
        //    {
        //        var dbList = client.ListDatabaseNames().ToList();
        //        Console.WriteLine("Databases:");
        //        foreach (var db in dbList)
        //        {
        //            Console.WriteLine(db);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error connecting to MongoDB: {ex.Message}");
        //    }
        //}
    }



}
