using Ardalis.Specification;

namespace Cuatroo.Inventamigo.SharedKernel.Interfaces;

// from Ardalis.Specification
public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
{
}
