using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.Attributes.Abstractions;

/// <summary>
/// Base service lifetime attribute for dependency injection
/// </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
public abstract class ServiceLifetimeAttributeBase : InjectionAttribute
{
    /// <summary>
    /// Service type which will be registered
    /// </summary>
    public Type ServiceType { get; }
    
    /// <summary>
    /// Implementation type of <see cref="ServiceType"/>. If null on registration <see cref="ImplementationType"/> will be equals with type which contains this attribute
    /// </summary>
    public Type? ImplementationType { get; }
    
    //public bool DefaultBehavior { get; } //TODO - Need analyse
    
    /// <summary>
    /// Service lifetime
    /// </summary>
    public abstract ServiceLifetime ServiceLifetime { get; }

    /// <summary>
    /// Initialize new instance of <see cref="ServiceLifetimeAttributeBase"/> for default region 
    /// </summary>
    /// <param name="serviceType">Service type for registration</param>
    protected ServiceLifetimeAttributeBase(Type serviceType)
    {
        ServiceType = serviceType;
        //DefaultBehavior = true; //TODO - Need analyse
    }

    /// <summary>
    /// Initialize new instance of <see cref="ServiceLifetimeAttributeBase"/> for default region and custom realization type
    /// </summary>
    /// <param name="serviceType">Service type for registration</param>
    /// <param name="implementationType">Custom realization type for <see cref="ServiceType"/></param>
    protected ServiceLifetimeAttributeBase(Type serviceType, Type implementationType)
        : this(serviceType)
    {
        ImplementationType = implementationType;
    }
    
    /// <summary>
    /// Initialize new instance of <see cref="ServiceLifetimeAttributeBase"/> for selected region
    /// </summary>
    /// <param name="serviceType">Service type for registration</param>
    /// <param name="region">Registration region name</param>
    protected ServiceLifetimeAttributeBase(Type serviceType, string region)
        : base(region)
    {
        ServiceType = serviceType;
    }

    /// <summary>
    /// Initialize new instance of <see cref="ServiceLifetimeAttributeBase"/> for selected region with custom realization type
    /// </summary>
    /// <param name="serviceType">Service type for registration</param>
    /// <param name="implementationType">Custom realization type for <see cref="ServiceType"/></param>
    /// <param name="region">Registration region name</param>
    protected ServiceLifetimeAttributeBase(Type serviceType, Type implementationType, string region)
        : this(serviceType, region)
    {
        ImplementationType = implementationType;
    }

    /// <inheritdoc/>
    public override string ToString() => $"ServiceType: {ServiceType}, Region: '{Region.Name}'";
}