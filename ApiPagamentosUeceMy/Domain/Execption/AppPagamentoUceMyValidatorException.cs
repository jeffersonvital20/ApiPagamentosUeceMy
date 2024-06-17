namespace ApiPagamentosUeceMy.Domain.Execption;

public class AppPagamentoUceMyValidatorException : Exception
{
    public AppPagamentoUceMyValidatorException(Dictionary<string, IEnumerable<string>> errors) : base("Invalid data")
        => Errors = errors;

    public Dictionary<string, IEnumerable<string>> Errors { get; }
}
