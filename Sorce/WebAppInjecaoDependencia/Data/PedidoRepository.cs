using WebAppInjecaoDependencia.Models;

namespace WebAppInjecaoDependencia.Data
{
    public class PedidoRepository : IPedidoRepository
    {
        public PedidoModel ObterPedido()
        {
            return new PedidoModel();
        }
    }

    public interface IPedidoRepository
    {
        PedidoModel ObterPedido();
    }
}
