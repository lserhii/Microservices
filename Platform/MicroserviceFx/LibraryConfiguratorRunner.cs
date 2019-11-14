using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MicroserviceFx
{
    public static class LibraryConfiguratorRunner
    {
        public static void ConfigureLibraries(IServiceCollection services)
        {
            var assemblies = new List<Assembly>();

            foreach (var assemblyName in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                assemblies.Add(AppDomain.CurrentDomain.Load(assemblyName));
            }

            assemblies
                .SelectMany(a => a.ExportedTypes.Where(t => typeof(ILibraryConfigurator).IsAssignableFrom(t) && t.IsClass && !t.IsAbstract && t.GetConstructors().Any(c => c.IsPublic && !c.GetParameters().Any())))
                .Select(t => (ILibraryConfigurator)Activator.CreateInstance(t))
                .ToList()
                .ForEach(l => l.ConfigureServices(services));

        }
    }
}
