using FluentValidation.Results;
using MediatR;
using SE.Core.Messages;

namespace SE.Pedidos.API.Application.Commands
{
    public class PedidoCommandHandler : CommandHandler,
        IRequestHandler<AdicionarPedidoCommand, ValidationResult>
    {
        public Task<ValidationResult> Handle(AdicionarPedidoCommand message, CancellationToken cancellationToken)
        {
            // Validação do comando

            // Mapear Pedido

            // Aplicar voucher se houver

            // Validar Pedido

            // Processar pagamento

            // Se pagamento tudo ok!

            // Adicionar Evento

            // Adicionar Pedido Repositorio

            // Persistir dados de pedido e voucher
        }
    }
}
