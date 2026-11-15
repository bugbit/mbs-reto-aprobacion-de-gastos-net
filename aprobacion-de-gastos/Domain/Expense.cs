using System;
using aprobacion_de_gastos.Common;

namespace aprobacion_de_gastos.Domain;

public enum ExpenseState { Pending, Approved, Rejected }

public class Expense
{
    public ExpenseId ExpenseId { get; }
    public EmployeeId EmployeeId { get; }
    public string Description { get; }
    public ExpenseCategory Category { get; }
    public Money Amount { get; }
    public DateTime SubmitDate { get; }
    public ExpenseState State { get; }

    private Expense(ExpenseId expenseId, EmployeeId employeeId, string description, ExpenseCategory category, Money amount, DateTime submitDate, ExpenseState state)
    {
        ExpenseId = expenseId;
        EmployeeId = employeeId;
        Description = description;
        Category = category;
        Amount = amount;
        SubmitDate = submitDate;
        State = state;
    }

    private Expense Submit(ExpenseId expenseId, EmployeeId employeeId, string description, ExpenseCategory category, Money amount, DateTime submitDate)
    {
        //  El importe debe ser mayor que cero y la descripción no puede estar vacía.
        if (amount.Cents <= 0)
            throw new DomainRuleViolationException("Amount must be greater than zero.");

        if (string.IsNullOrWhiteSpace(description))
            throw new DomainRuleViolationException("Description cannot be empty.");

        ExpenseState state = ExpenseState.Pending;

        return new Expense(expenseId, employeeId, description, category, amount, submitDate, state);
    }
}
