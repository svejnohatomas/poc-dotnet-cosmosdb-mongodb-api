using MongoDB.Driver;
using poc_dotnet_cosmosdb_mongodb_api.Models;

namespace poc_dotnet_cosmosdb_mongodb_api.Services
{
    public class MongoService
    {
        private static MongoClient _client;

        public MongoService(IDatabaseSettings settings)
        {
            _client = new MongoClient(settings.MongoConnectionString);
        }

        public MongoClient GetClient()
        {
            return _client;
        }
    }
}