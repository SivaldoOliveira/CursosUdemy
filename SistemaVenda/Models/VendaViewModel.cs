﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SistemaVenda.DAL;
using SistemaVenda.Entidades;
using SistemaVenda.Models;
using System.Web;
using SistemaVenda.Controllers;

namespace SistemaVenda.Models
{
    public class VendaViewModel
    {
        public int? Codigo { get; set; }

        [Required(ErrorMessage="Informe a Data da Venda!")]
        public DateTime? Data { get; set; }

        [Required(ErrorMessage = "Informe o Cliente!")]
        public int? CodigoCliente{ get; set; }

        public IEnumerable<SelectListItem> ListaClientes { get; set; }

        public IEnumerable<SelectListItem> ListaProdutos { get; set; }

        public string JsonProdutos { get; set; }

        public decimal Total { get; set; }

    }
}
