using System;
using aprobacion_de_gastos.Common;

namespace aprobacion_de_gastos.Domain;

public class Money
{
    private readonly Int128 _cents;

    private Money(Int128 cents)
    {
        _cents = cents;
    }

    public static Money FromCents(Int128 cents)
    {
        if (cents < 0)
            throw new DomainRuleViolationException("Money must contain a non-negative integer number of cents.");

        return new Money(cents);
    }

    public Int128 Cents => _cents;

    public bool IsGreaterThan(Money other)
    {
        return _cents > other._cents;
    }
}
