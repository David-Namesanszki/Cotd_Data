using Cotd_Data.Models.Maps;
using Cotd_Data.Models.Maps.LocationPaths;
using Cotd_Data.Models.Maps.Locations;

namespace Cotd_Data._Interfaces
{
    public interface IMapRepository
    {
        MapData GetOne(string id);
        void Update(MapData entity);
        void UpdateMap(string id, IList<LocationData> locations, IList<LocationPathData> locationPathDatas);
    }
}