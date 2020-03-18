using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVenda.DAL;
using SistemaVenda.Entidades;

namespace SistemaVenda.Controllers
{
    public class CategoriaController : Controller
    {

        protected ApplicationDbContext mContext;

        public  CategoriaController (ApplicationDbContext context)
        {
            mContext = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Categoria> lista = mContext.Categoria.ToList();
            mContext.Dispose();
            return View(lista);
        }
    }
}