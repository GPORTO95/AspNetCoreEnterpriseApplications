using SE.Core.DomainObjects;

namespace SE.Pedidos.Domain.Pedidos
{
    public class PedidoItem : Entity
    {
        // Ef ctor
        protected PedidoItem() { }

        public PedidoItem(Guid produtoId, string produtoNome, int quantidaade, decimal valorUnitario, string produtoImagem = null)
        {
            //PedidoId = pedidoId;
            ProdutoId = produtoId;
            ProdutoNome = produtoNome;
            Quantidaade = quantidaade;
            ValorUnitario = valorUnitario;
            ProdutoImagem = produtoImagem;
        }

        public Guid PedidoId { get; private set; }
        public Guid ProdutoId { get; private set; }
        public string ProdutoNome { get; private set; }
        public int Quantidaade { get; private set; }
        public decimal ValorUnitario { get; private set; }
        public string ProdutoImagem { get; private set; }

        // EF Rel.
        public Pedido Pedido { get; private set; }

        internal decimal CalcularValor() =>
            Quantidaade * ValorUnitario;
    }
}
