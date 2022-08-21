using SE.Core.Messages.Integration;
using SE.Pagamentos.API.Models;

namespace SE.Pagamentos.API.Services
{
    public interface IPagamentoService
    {
        Task<ResponseMessage> AutorizarPagamento(Pagamento pagamento);
        Task<ResponseMessage> CapturarPagamento(Guid pedidoId);
        Task<ResponseMessage> CancelarPagamento(Guid pedidoId);
    }


    public class PagamentoService : IPagamentoService
    {
        public Task<ResponseMessage> AutorizarPagamento(Pagamento pagamento)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseMessage> CancelarPagamento(Guid pedidoId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseMessage> CapturarPagamento(Guid pedidoId)
        {
            throw new NotImplementedException();
        }
    }
}
