namespace WebAppInjecaoDependencia.Models
{
    public class PedidoModel
    {
        public Guid Id { get; set; }

        public PedidoModel()
        {
            Id = Guid.NewGuid();
        }
    }
}
