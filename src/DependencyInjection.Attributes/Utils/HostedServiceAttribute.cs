using DependencyInjection.Attributes.Abstractions;

namespace DependencyInjection.Attributes.Utils;

/// <summary>
/// Attribute for register hosted service in dependency injection container
/// </summary>
[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class HostedServiceAttribute : InjectionAttribute
{
    /// <summary>
    /// Initialize new instance of <see cref="HostedServiceAttribute"/> for default region
    /// </summary>
    public HostedServiceAttribute()
    {
    }
    
    /// <summary>
    /// Initialize new instance of <see cref="HostedServiceAttribute"/> for selected region
    /// </summary>
    /// <param name="region">Registration region name</param>
    public HostedServiceAttribute(string region)
        : base(region)
    {
    }
}