using SE.Core.DomainObjects;

namespace SE.Clientes.API.Models
{
    public class Endereco : Entity
    {
        // EF Constructor
        protected Endereco() { }

        public Endereco(string logradouro, string numero, string complemento, string bairro, string cep, string cidade, string estado, Guid clienteId)
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cep = cep;
            Cidade = cidade;
            Estado = estado;
            ClienteId = clienteId;
        }

        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cep { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }

        // EF Relation
        public Guid ClienteId { get; private set; }
        public Cliente Cliente { get; protected set; }
    }
}
