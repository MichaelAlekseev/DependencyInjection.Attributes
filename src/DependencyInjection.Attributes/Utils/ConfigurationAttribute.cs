namespace DependencyInjection.Attributes.Utils;

/// <summary>
/// Attribute for register configuration in dependency injection container
/// </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
public sealed class ConfigurationAttribute : Attribute
{
    /// <summary>
    /// Type of configuration
    /// </summary>
    public Type ConfigurationType { get; }
    
    /// <summary>
    /// Configuration file section name
    /// </summary>
    public string SectionName { get; }

    /// <summary>
    /// Initialize new instance of <see cref="ConfigurationAttribute"/> where <see cref="SectionName"/> equals <see cref="ConfigurationType"/> name
    /// </summary>
    /// <param name="configurationType">Configuration type to register</param>
    public ConfigurationAttribute(Type configurationType)
        : this(configurationType, configurationType.Name)
    {
    }

    /// <summary>
    /// Initialize new instance of <see cref="ConfigurationAttribute"/> with custom section name
    /// </summary>
    /// <param name="configurationType">Configuration type to register</param>
    /// <param name="sectionName">Configuration file section name</param>
    public ConfigurationAttribute(Type configurationType, string sectionName)
    {
        ConfigurationType = configurationType;
        SectionName = sectionName;
    }
}