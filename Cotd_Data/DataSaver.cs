using System.Text.Json;

namespace Cotd_Data;

public static class DataSaver<T> where T : class
{
	public static void Save(IList<T> data, string path)
	{
		var options = new JsonSerializerOptions { WriteIndented = true };
		string json = JsonSerializer.Serialize(data, options);
		File.WriteAllText(path, json);
	}
}
