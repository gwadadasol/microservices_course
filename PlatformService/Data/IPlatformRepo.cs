using PlatformService.Models;

namespace PlatformService.Data
{
    public interface IPlatformRepo
    {
        bool SaveChanges();

        IEnumerable<Platform> GetAllPlaforms();
        Platform GetPlatformById(int id);
        void CreatePlatform(Platform plat);
    }
}