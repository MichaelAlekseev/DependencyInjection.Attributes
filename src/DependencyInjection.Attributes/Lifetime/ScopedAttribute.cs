using DependencyInjection.Attributes.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.Attributes.Lifetime;

/// <summary>
/// Scoped service lifetime attribute for dependency injection
/// </summary>
public sealed class ScopedAttribute : ServiceLifetimeAttributeBase
{
    /// <inheritdoc/>
    public override ServiceLifetime ServiceLifetime => ServiceLifetime.Scoped;

    /// <summary>
    /// Initialize new instance of <see cref="ScopedAttribute"/> for default region
    /// </summary>
    /// <param name="serviceType">Service type for registration</param>
    public ScopedAttribute(Type serviceType) : base(serviceType)
    {
    }

    /// <summary>
    /// Initialize new instance of <see cref="ScopedAttribute"/> for default region and custom realization type
    /// </summary>
    /// <param name="serviceType">Service type for registration</param>
    /// <param name="implementationType">Custom realization type for serviceType</param>
    public ScopedAttribute(Type serviceType, Type implementationType) 
        : base(serviceType, implementationType)
    {
    }

    /// <summary>
    /// Initialize new instance of <see cref="ScopedAttribute"/> for selected region
    /// </summary>
    /// <param name="serviceType">Service type for registration</param>
    /// <param name="region">Registration region name</param>
    public ScopedAttribute(Type serviceType, string region) 
        : base(serviceType, region)
    {
    }

    /// <summary>
    /// Initialize new instance of <see cref="ScopedAttribute"/> for selected region with custom realization type
    /// </summary>
    /// <param name="serviceType">Service type for registration</param>
    /// <param name="implementationType">Custom realization type for serviceType</param>
    /// <param name="region">Registration region name</param>
    public ScopedAttribute(Type serviceType, Type implementationType, string region) 
        : base(serviceType, implementationType, region)
    {
    }
}