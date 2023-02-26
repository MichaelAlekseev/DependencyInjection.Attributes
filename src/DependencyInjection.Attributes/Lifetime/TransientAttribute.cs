using DependencyInjection.Attributes.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.Attributes.Lifetime;

/// <summary>
/// Transient service lifetime attribute for dependency injection
/// </summary>
public sealed class TransientAttribute : ServiceLifetimeAttributeBase
{
    /// <inheritdoc/>
    public override ServiceLifetime ServiceLifetime => ServiceLifetime.Transient;

    /// <summary>
    /// Initialize new instance of <see cref="TransientAttribute"/> for default region
    /// </summary>
    /// <param name="serviceType">Service type for registration</param>
    public TransientAttribute(Type serviceType) : base(serviceType)
    {
    }

    /// <summary>
    /// Initialize new instance of <see cref="TransientAttribute"/> for default region and custom realization type
    /// </summary>
    /// <param name="serviceType">Service type for registration</param>
    /// <param name="implementationType">Custom realization type for serviceType</param>
    public TransientAttribute(Type serviceType, Type implementationType) 
        : base(serviceType, implementationType)
    {
    }

    /// <summary>
    /// Initialize new instance of <see cref="TransientAttribute"/> for selected region
    /// </summary>
    /// <param name="serviceType">Service type for registration</param>
    /// <param name="region">Registration region name</param>
    public TransientAttribute(Type serviceType, string region) 
        : base(serviceType, region)
    {
    }

    /// <summary>
    /// Initialize new instance of <see cref="TransientAttribute"/> for selected region with custom realization type
    /// </summary>
    /// <param name="serviceType">Service type for registration</param>
    /// <param name="implementationType">Custom realization type for serviceType</param>
    /// <param name="region">Registration region name</param>
    public TransientAttribute(Type serviceType, Type implementationType, string region) 
        : base(serviceType, implementationType, region)
    {
    }
}