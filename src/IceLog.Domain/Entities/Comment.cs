using IceLog.Domain.Commons;

namespace IceLog.Domain.Entities;

public class Comment : Auditable
{
    public required string Content { get; set; }
    public Guid PostId { get; set; }
    public Post Post { get; set; } = null!;
    public Guid AuthorId { get; set; }
    public User Author { get; set; } = null!;
}