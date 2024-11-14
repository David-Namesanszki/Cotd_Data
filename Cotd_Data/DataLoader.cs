using System.Text.Json;

namespace Cotd_Data;

public static class DataLoader<T> where T : class
{
    public static IList<T> Load(string file)
    {
        string json = File.ReadAllText(file);
        return JsonSerializer.Deserialize<IList<T>>(json) ?? throw new Exception();
    }
}
