// using System.Threading.Tasks;
using PlatformService.Dtos;

namespace PlatformService.SyncDataServices.Http
{
    public interface ICommandDataClient
    {
        Task SendPlatformToCmmand(PlatformReadDto plat);
        
    }
}