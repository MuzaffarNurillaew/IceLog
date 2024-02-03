using IceLog.Domain.Commons;

namespace IceLog.Domain.Entities.Relationals;
/// <inheritdoc cref="Auditable"/>
public class PostTag : Auditable
{
    public Guid PostId { get; set; }
    public Post Post { get; set; } = null!;
    public Guid TagId { get; set; }
    public Tag Tag { get; set; } = null!;
}