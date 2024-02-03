using System.ComponentModel.DataAnnotations;

namespace IceLog.Domain.Commons;

public abstract class Auditable
{
    /// <summary>
    /// Gets or sets Id of the entity.
    /// </summary>
    [Key]
    public Guid Id { get; set; }
    /// <summary>
    /// Gets or sets created date of the entity.
    /// </summary>
    public DateTimeOffset CreatedAt { get; set; }
    /// <summary>
    /// Gets or sets the state of deleted or not for the entity.
    /// </summary>
    public bool IsDeleted { get; set; }
    /// <summary>
    /// Gets or sets the deleted date of the entity.
    /// </summary>
    public DateTimeOffset? DeletedAt { get; set; }
    /// <summary>
    /// Gets or sets the updated date of the entity.
    /// </summary>
    public DateTimeOffset? UpdatedAt { get; set; }
}