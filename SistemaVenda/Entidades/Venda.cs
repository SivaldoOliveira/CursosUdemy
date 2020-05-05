using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ForeignKeyAttribute = System.ComponentModel.DataAnnotations.Schema.ForeignKeyAttribute;

namespace SistemaVenda.Entidades
{
    public class Venda
    {
       
        [Key]
        public int? Codigo { get; set; }
        public DateTime Data { get; set; }

        [ForeignKey("Cliente")]
        public int CodigoCliente { get; set; }
        public Cliente Cliente { get; set; }
        public decimal Total { get; set; }

        public ICollection<VendaProdutos> Produtos { get; set; }

    }
}