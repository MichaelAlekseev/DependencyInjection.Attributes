namespace DependencyInjection.Attributes.Entities;

/// <summary>
/// Representation of registration region
/// </summary>
public readonly struct Region
{
    /// <summary>
    /// Name of region
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Default region
    /// </summary>
    public static Region Default => new(string.Empty);
    
    /// <summary>
    /// Initialize new instance of <see cref="Region"/>
    /// </summary>
    /// <param name="name">Region name</param>
    public Region(string name)
    {
        Name = name;
    }
}