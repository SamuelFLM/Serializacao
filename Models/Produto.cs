using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Serializacao.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome_Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }

        public Produto(int id, string nomeProduto, decimal preco, DateTime dataVenda){
            Id = id;
            Nome_Produto = nomeProduto;
            Preco = preco;
            DataVenda = dataVenda;
        }
        
    }
}