using Cotd_Data._Interfaces;
using Cotd_Data.Models.Maps;
using Cotd_Data.Models.Maps.LocationPaths;
using Cotd_Data.Models.Maps.Locations;

namespace Cotd_Data.Repositories;

public class MapRepository : BaseRepository<MapData>, IMapRepository
{
	public MapRepository(string dataPath) : base(dataPath)
	{
	}

	public override MapData GetOne(string id)
	{
		var map = GetAll().FirstOrDefault(c => c.Id == id);
		return map ?? throw new KeyNotFoundException($"Card with ID {id} not found.");
	}

	public override void Update(MapData entity)
	{
		UpdateMap(entity.Id, entity.Locations, entity.LocationPaths);
	}

	public void UpdateMap(string id, IList<LocationData> locations, IList<LocationPathData> locationPathDatas)
	{
		var datas = GetAll();
		MapData? map = datas.FirstOrDefault(c => c.Id == id) ?? throw new KeyNotFoundException($"Game with ID {id} not found.");

		map.Locations = locations;
		map.LocationPaths = locationPathDatas;

		DataSaver<MapData>.Save(datas, dataPath);
	}
}
