using DependencyInjection.Attributes.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.Attributes.Lifetime;

/// <summary>
/// Singleton service lifetime attribute for dependency injection
/// </summary>
public sealed class SingletonAttribute : ServiceLifetimeAttributeBase
{
    /// <inheritdoc/>
    public override ServiceLifetime ServiceLifetime => ServiceLifetime.Singleton;

    /// <summary>
    /// Initialize new instance of <see cref="SingletonAttribute"/> for default region
    /// </summary>
    /// <param name="serviceType">Service type for registration</param>
    public SingletonAttribute(Type serviceType) : base(serviceType)
    {
    }

    /// <summary>
    /// Initialize new instance of <see cref="SingletonAttribute"/> for default region and custom realization type
    /// </summary>
    /// <param name="serviceType">Service type for registration</param>
    /// <param name="implementationType">Custom realization type for serviceType</param>
    public SingletonAttribute(Type serviceType, Type implementationType) 
        : base(serviceType, implementationType)
    {
    }

    /// <summary>
    /// Initialize new instance of <see cref="SingletonAttribute"/> for selected region
    /// </summary>
    /// <param name="serviceType">Service type for registration</param>
    /// <param name="region">Registration region name</param>
    public SingletonAttribute(Type serviceType, string region) 
        : base(serviceType, region)
    {
    }

    /// <summary>
    /// Initialize new instance of <see cref="SingletonAttribute"/> for selected region with custom realization type
    /// </summary>
    /// <param name="serviceType">Service type for registration</param>
    /// <param name="implementationType">Custom realization type for serviceType</param>
    /// <param name="region">Registration region name</param>
    public SingletonAttribute(Type serviceType, Type implementationType, string region) 
        : base(serviceType, implementationType, region)
    {
    }
}