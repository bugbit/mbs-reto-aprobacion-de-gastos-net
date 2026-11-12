using System;

namespace aprobacion_de_gastos.Domain;

public enum Roles { Employee, Manager, Finance }

public record Employee(EmployeeId Id, string Name, Roles Role)
{

}
