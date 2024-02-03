using IceLog.Domain.Commons;

namespace IceLog.Domain.Entities;

/// <inheritdoc cref="Auditable"/>
public class Category : Auditable
{
    public required string Name { get; set; }
}