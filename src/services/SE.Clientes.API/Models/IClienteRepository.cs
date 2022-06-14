using SE.Core.Data;

namespace SE.Clientes.API.Models
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        // Cliente
        Task<IEnumerable<Cliente>> ObterTodos();
        Task<Cliente> ObterPorCpf(string cpf);
        void Adicionar(Cliente cliente);
        // Endereco
        Task<Endereco> ObterEnderecoPorId(Guid id);
        void AdicionarEndereco(Endereco endereco);
    }
}
