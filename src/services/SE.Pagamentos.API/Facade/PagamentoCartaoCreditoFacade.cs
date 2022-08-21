using Microsoft.Extensions.Options;
using SE.Pagamentos.API.Models;

namespace SE.Pagamentos.API.Facade
{
    public class PagamentoCartaoCreditoFacade : IPagamentoFacade
    {
        private readonly PagamentoConfig _pagamentoConfig;

        public PagamentoCartaoCreditoFacade(IOptions<PagamentoConfig> pagamentoConfig)
        {
            _pagamentoConfig = pagamentoConfig.Value;
        }

        public Task<Transacao> AutorizarPagamento(Pagamento pagamento)
        {
            throw new NotImplementedException();
        }

        public Task<Transacao> CapturarPagamento(Transacao transacao)
        {
            throw new NotImplementedException();
        }

        public Task<Transacao> CancelarAutorizacao(Transacao transacao)
        {
            throw new NotImplementedException();
        }
    }
}
