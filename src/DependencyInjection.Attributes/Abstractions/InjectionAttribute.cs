using DependencyInjection.Attributes.Entities;

namespace DependencyInjection.Attributes.Abstractions;

/// <summary>
/// Base attribute type for dependency injections
/// </summary>
public abstract class InjectionAttribute : Attribute
{
    /// <summary>
    /// Region in which the service will be registered
    /// </summary>
    public Region Region { get; }

    /// <summary>
    /// Initialize new instance of <see cref="InjectionAttribute"/> for default region
    /// </summary>
    protected InjectionAttribute()
    {
        Region = Region.Default;
    }

    /// <summary>
    /// Initialize new instance of <see cref="InjectionAttribute"/> for selected region
    /// </summary>
    /// <param name="region">Registration region name</param>
    protected InjectionAttribute(string region)
    {
        Region = new Region(region);
    }
}