using Autofac;
using Cuatroo.Inventamigo.Core.Interfaces;
using Cuatroo.Inventamigo.Core.Services;

namespace Cuatroo.Inventamigo.Core;

public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterType<ToDoItemSearchService>()
        .As<IToDoItemSearchService>().InstancePerLifetimeScope();
  }
}
