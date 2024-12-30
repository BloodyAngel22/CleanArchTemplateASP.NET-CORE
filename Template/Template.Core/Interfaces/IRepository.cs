namespace Template.Core.Interfaces
{
	public interface IRepository<TType, TId>
	{
		Task<IEnumerable<TType>> GetAllAsync();
		Task<TType> GetAsync(TId id);
		Task AddAsync(TType entity);
		Task UpdateAsync(TId id, TType entity);
		Task DeleteAsync(TId id);
	}
}