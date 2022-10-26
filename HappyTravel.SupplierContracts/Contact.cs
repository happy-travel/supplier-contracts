namespace HappyTravel.SupplierContracts;

public record Contact
{
    public string FullName { get; init; } = string.Empty;
    public string? Email { get; init; }
    public string? Phone { get; init; }
    public string? Description { get; init; }
}