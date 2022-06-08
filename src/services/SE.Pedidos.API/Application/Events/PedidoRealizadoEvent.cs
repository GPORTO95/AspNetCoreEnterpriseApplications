using SE.Core.Messages;

namespace SE.Pedidos.API.Application.Events
{
    public class PedidoRealizadoEvent : Event
    {
        public PedidoRealizadoEvent(Guid pedidoId, Guid clienteId)
        {
            PedidoId = pedidoId;
            ClienteId = clienteId;
        }

        public Guid PedidoId { get; private set; }
        public Guid ClienteId { get; private set; }
    }
}
