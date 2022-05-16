using Cuatroo.Inventamigo.Core.ProjectAggregate;
using Cuatroo.Inventamigo.SharedKernel;

namespace Cuatroo.Inventamigo.Core.ProjectAggregate.Events;

public class ToDoItemCompletedEvent : BaseDomainEvent
{
  public ToDoItem CompletedItem { get; set; }

  public ToDoItemCompletedEvent(ToDoItem completedItem)
  {
    CompletedItem = completedItem;
  }
}
