using CommandsService.Models;
using CommandsService.SyncDataServices.Grpc;

namespace CommandsService.Data
{
    public static class PrepDb
    {
        //we can't use constructor injection here, as this is a static class
        public static void PrepPopulation(IApplicationBuilder applicationBuilder)
        {
            using (var serivceScope = applicationBuilder.ApplicationServices.CreateScope() )
            {
                var grpcClient = serivceScope.ServiceProvider.GetService<IPlatformDataClient>();
                
                var platforms = grpcClient.ReturnAllPlatforms();
            
                SeedData(serivceScope.ServiceProvider.GetService<ICommandRepo>(), platforms);
            }
        }
        private static void SeedData(ICommandRepo repo, IEnumerable<Platform> platforms)
        {
            Console.WriteLine("--> Seeding new platforms...");

            foreach(var plat in platforms)
            {
                if(!repo.ExternalPlatformExists(plat.ExternalID))
                {
                    repo.CreatePlatform(plat);
                }
                repo.SaveChanges();
            }
        }
    }
}