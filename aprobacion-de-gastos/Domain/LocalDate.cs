using System;

namespace aprobacion_de_gastos.Domain;

public class LocalDate
{
    private readonly DateTime _dateTime;

    private LocalDate(DateTime dateTime)
    {
        _dateTime = dateTime.Date;
    }

    public static LocalDate FromDateTime(DateTime dateTime)
    {
        return new LocalDate(dateTime.ToUniversalTime().Date);
    }

    override public string ToString()
    {
        return _dateTime.ToString("yyyy-MM-dd");
    }
}
