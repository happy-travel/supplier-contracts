namespace HappyTravel.SupplierContracts;

public record SlimSupplier
{
    public string Code { get; init; } = string.Empty;
    public string Name { get; init; } = string.Empty;
    public EnableState EnableState { get; init; }
    public string ConnectorUrl { get; init; } = string.Empty;
    public string? ConnectorGrpcEndpoint { get; init; }
    public string? ConnectorUpdaterEndpoint { get;init; }
    public bool IsMultiRoomFlowSupported { get; init; }
    public Dictionary<string, string>? CustomHeaders { get; init; }
    public bool CanUseGrpc { get; init; }
    public bool CanUseVcc { get; init; }
    public string? GiataCode { get; init; }
    public bool IsDirectContract { get; init; }
}