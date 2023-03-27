namespace sistemasOperativos.Contracts

public record sistemasOperativos(
    string Name,
    string Description,
    Datetime StartDateTime,
    Datetime EndDateTime,
    List<string> Savory,
    List<string> Sweet);
