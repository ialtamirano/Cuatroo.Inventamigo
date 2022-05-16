using Ardalis.Result;
using Cuatroo.Inventamigo.Core.ProjectAggregate;

namespace Cuatroo.Inventamigo.Core.Interfaces;

public interface IToDoItemSearchService
{
  Task<Result<ToDoItem>> GetNextIncompleteItemAsync(int projectId);
  Task<Result<List<ToDoItem>>> GetAllIncompleteItemsAsync(int projectId, string searchString);
}
