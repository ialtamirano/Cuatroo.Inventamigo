using Ardalis.Specification;
using Cuatroo.Inventamigo.Core.ProjectAggregate;

namespace Cuatroo.Inventamigo.Core.ProjectAggregate.Specifications;

public class ProjectByIdWithItemsSpec : Specification<Project>, ISingleResultSpecification
{
  public ProjectByIdWithItemsSpec(int projectId)
  {
    Query
        .Where(project => project.Id == projectId)
        .Include(project => project.Items);
  }
}
