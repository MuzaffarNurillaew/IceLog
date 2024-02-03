using IceLog.Domain.Commons;

namespace IceLog.Domain.Entities.Addresses;

/// <inheritdoc cref="Auditable"/>
public class Address : Auditable
{
    /// <summary>
    /// Gets or sets the id of city of address.
    /// </summary>
    public Guid? CityId { get; set; }
    /// <summary>
    /// Gets or sets the city of address based on <see cref="CityId"/>.
    /// </summary>
    public City? City { get; set; }
    /// <summary>
    /// Gets or sets the street.
    /// </summary>
    public string? Street { get; set; }
    /// <summary>
    /// Represents zip code.
    /// </summary>
    public string? ZipCode { get; set; }
    /// <summary>
    /// Represents house number.
    /// </summary>
    public string? HouseNumber { get; set; }
    /// <summary>
    /// Represents longitude.
    /// </summary>
    public decimal? Longitude { get; set; }
    /// <summary>
    /// Represents latitude.
    /// </summary>
    public decimal? Latitude { get; set; }
    /// <summary>
    /// Represents <see cref="Post"/>s written in this address.
    /// </summary>
    public ICollection<Post>? Posts { get; set; }
}