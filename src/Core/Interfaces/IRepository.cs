namespace Core.Interfaces {
	/// <summary>
	/// Generic repository interface for all entities.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	internal interface IRepository<T> {
		Task<T> GetByIdAsync(int id);
		Task<IEnumerable<T>> GetAllAsync();
		Task AddAsync(T entity);
		Task UpdateAsync(T entity);
		Task DeleteAsync(int id);
	}
}
