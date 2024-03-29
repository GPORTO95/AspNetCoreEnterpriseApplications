﻿using SE.Core.DomainObjects;

namespace SE.Catalogo.API.Models
{
    public class Produto : Entity, IAggregateRoot
    {
        public int QuantidadeEstoque { get; set; }

        public bool Ativo { get; set; }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        
        public decimal Valor { get; set; }

        public DateTime DataCadastro { get; set; }

        public void RetirarEstoque(int quantidade)
        {
            if(QuantidadeEstoque >= quantidade)
                QuantidadeEstoque -= quantidade;
        }

        public bool EstaDisponivel(int quantidade)
        {
            return Ativo && QuantidadeEstoque >= quantidade;
        }
        
    }
}
