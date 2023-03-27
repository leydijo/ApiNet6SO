namespace sistemasOperativos.Contracts

public record SoResponse(
    string Name,
    string Description,
    Datetime StartDateTime,
    Datetime EndDateTime,
    List<string> Savory,
    List<string> Sweet);
