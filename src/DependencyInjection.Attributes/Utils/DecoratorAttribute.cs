using DependencyInjection.Attributes.Abstractions;

namespace DependencyInjection.Attributes.Utils;

/// <summary>
/// Attribute for decoration already registered service in dependency injection container
/// </summary>
[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public sealed class DecoratorAttribute : InjectionAttribute
{
    /// <summary>
    /// Service type to decorate
    /// </summary>
    public Type TypeToDecorate { get; }

    /// <summary>
    /// Initialize new instance of <see cref="DecoratorAttribute"/> for default region
    /// </summary>
    /// <param name="typeToDecorate">Service type in DI to decorate</param>
    public DecoratorAttribute(Type typeToDecorate)
    {
        TypeToDecorate = typeToDecorate;
    }

    /// <summary>
    /// Initialize new instance of <see cref="DecoratorAttribute"/> for selected region
    /// </summary>
    /// <param name="typeToDecorate">Service type in DI to decorate</param>
    /// <param name="region">Registration region name</param>
    public DecoratorAttribute(Type typeToDecorate, string region)
        : base(region)
    {
        TypeToDecorate = typeToDecorate;
    }
}