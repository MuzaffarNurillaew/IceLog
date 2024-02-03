using IceLog.Domain.Commons;

namespace IceLog.Domain.Entities;

/// <inheritdoc cref="Auditable"/>
public class Tag : Auditable
{
    public required string Name { get; set; }
    public List<Post> Posts { get; set; } = new();
}