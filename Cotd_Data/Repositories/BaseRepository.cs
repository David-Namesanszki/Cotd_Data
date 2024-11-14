using Cotd_Data.Models.Cards;
using Microsoft.EntityFrameworkCore;

namespace Cotd_Data.Repositories;

public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
{
	protected string dataPath;
	protected BaseRepository(string dataPath)
	{
		this.dataPath = dataPath;
	}

	/// <summary>
	/// Gets or sets the database context.
	/// </summary>

	/// <inheritdoc/>
	public IList<T> GetAll()
	{
		return DataLoader<T>.Load(dataPath);
	}

	/// <inheritdoc/>
	public abstract T GetOne(string id);

	/// <inheritdoc/>
	public void Insert(T entity)
	{
		var datas = DataLoader<T>.Load(dataPath);
		datas.Add(entity);
		DataSaver<T>.Save(datas, dataPath);
	}

	/// <inheritdoc/>
	public void Remove(T entity)
	{
		var datas = DataLoader<T>.Load(dataPath);
		datas.Remove(entity);
		DataSaver<T>.Save(datas, dataPath);
	}
}
