﻿using Ardalis.Specification;

namespace Cuatroo.Inventamigo.SharedKernel.Interfaces;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
}
