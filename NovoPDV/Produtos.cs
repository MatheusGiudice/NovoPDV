using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoPDV
{
    public class Produtos
    {
        public int Id { get; set; }
        public string Nome { get; set;}
        public decimal Unitario { get; set; }
        
        public Produtos (int id, string nome, decimal unitario)
        {
            Id = id;
            Nome = nome;
            Unitario = unitario;
        }
    }
}
