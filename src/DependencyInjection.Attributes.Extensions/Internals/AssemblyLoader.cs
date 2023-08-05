using System.Reflection;
using DependencyInjection.Attributes.Extensions.Internals.Abstractions;

namespace DependencyInjection.Attributes.Extensions.Internals;

internal sealed class AssemblyLoader : IAssemblyLoader
{
    public void Load()
    {
        var currentDomain = AppDomain.CurrentDomain;
        var alreadyLoadedAssemblies = currentDomain.GetAssemblies();
        string[] allAssemblyPaths = Directory.GetFiles(currentDomain.BaseDirectory, "*.dll");
        var assembliesToLoad = allAssemblyPaths.Except(alreadyLoadedAssemblies.Where(x => !x.IsDynamic).Select(x => x.Location));
        foreach (string assemblyPath in assembliesToLoad)
            currentDomain.Load(AssemblyName.GetAssemblyName(assemblyPath));
    }
}