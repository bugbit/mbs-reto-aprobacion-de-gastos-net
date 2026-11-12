using System;

namespace aprobacion_de_gastos.Domain;

public record Identifier(string id);

public record EmployeeId(string id) : Identifier(id);