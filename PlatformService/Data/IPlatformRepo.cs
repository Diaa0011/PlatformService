using PlatformService.Models;

namespace PlatformService.Data
{
    public interface IplatformRepo
    {
        bool SaveChanges();

        IEnumerable<Platform> GetAllPlatforms();

        Platform GetPlatformById(int Id);

        void CreatePlatform(Platform plat); 
    }
}