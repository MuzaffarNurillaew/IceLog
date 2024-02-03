using IceLog.Domain.Commons;

namespace IceLog.Domain.Entities;

/// <inheritdoc cref="Auditable"/>
public class Post : Auditable
{
    public required string Title { get; set; }
    public required string Content { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; } = null!;
    public List<Tag> Tags { get; set; } = new();
}