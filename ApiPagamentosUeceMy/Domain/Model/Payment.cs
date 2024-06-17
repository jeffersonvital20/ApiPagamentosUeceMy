namespace ApiPagamentosUeceMy.Domain.Model;

public class Payment
{
    public Guid IdUsuario { get; set; }
    public Guid IdCurso { get; set; }
    public bool pago { get; set; }
}
