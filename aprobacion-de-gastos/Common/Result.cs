namespace aprobacion_de_gastos.Common;

public record Success<T>(T Value);
public record Failure(string Message);

public union Result<T>(Success<T>, Failure);