using System;
using System.Runtime.Serialization;

namespace aprobacion_de_gastos.Common;

public class DomainRuleViolationException : Exception
{
    public DomainRuleViolationException()
    {
    }

    public DomainRuleViolationException(string? message) : base(message)
    {
    }

    public DomainRuleViolationException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
