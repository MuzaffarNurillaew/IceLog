using IceLog.Domain.Commons;

namespace IceLog.Domain.Entities.Addresses;

public class Country : Auditable
{
    public required string Name { get; set; }
}