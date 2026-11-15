using System;
using aprobacion_de_gastos.Common;

namespace aprobacion_de_gastos.Domain;

public record Identifier
{
    private string _id;

    protected static Identifier Create<T>(string id) where T : Identifier, new()
    {
        T identifier = new();

        identifier.SetId(id);

        return identifier;
    }

    public string GetId() => _id;
    public void SetId(string id)
    {
        var trimmedId = id.Trim();

        if (string.IsNullOrWhiteSpace(trimmedId))
            throw new DomainRuleViolationException($"{GetType().Name} cannot be null or empty.");

        _id = trimmedId;
    }
}

public record EmployeeId : Identifier
{
    public static EmployeeId Create(string id) => (EmployeeId)Identifier.Create<EmployeeId>(id);
}

public record ExpenseId : Identifier
{
    public static ExpenseId Create(string id) => (ExpenseId)Identifier.Create<ExpenseId>(id);
}