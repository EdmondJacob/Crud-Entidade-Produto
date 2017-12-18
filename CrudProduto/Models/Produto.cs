using System;
using System.ComponentModel.DataAnnotations;

namespace CrudProduto.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public String Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public String Categoria { get; set; }
        public float Preco { get; set; }
        
    }
}