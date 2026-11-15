namespace aprobacion_de_gastos.Common;

public record Success<T>(T Value);
public record Failure(string Reason);

public union Result<T>(Success<T>, Failure);