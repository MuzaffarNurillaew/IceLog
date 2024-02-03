using IceLog.Domain.Commons;

namespace IceLog.Domain.Entities;

/// <inheritdoc cref="Auditable"/>
public class Like : Auditable
{
    public Guid? PostId { get; set; }
    public Post Post { get; set; } = null!;
    public Guid? CommentId { get; set; }
    public Comment Comment { get; set; } = null!;
    public Guid AuthorId { get; set; }
    public User Author { get; set; } = null!;
}