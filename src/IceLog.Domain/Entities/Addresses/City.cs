using IceLog.Domain.Commons;

namespace IceLog.Domain.Entities.Addresses;

public class City : Auditable
{
    public required string Name { get; set; }
}