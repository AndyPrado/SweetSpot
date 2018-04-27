using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SweetSpot.Models;

namespace SweetSpot.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var produtos = new List<Product>();

            produtos.Add(new Product(1, "Aromatizados de ambientes", (decimal)20.00, "Aromatizador de Ambientes preparado para deixar o seu ambiente com frescor", "aromatizador.png", null));
            produtos.Add(new Product(2, "Aromatizador para carros", (decimal)20.00, "Aromatizador de Ambientes preparado para deixar o seu carro com frescor", "carro.jpg", null));
            produtos.Add(new Product(3, "Home spray", (decimal)20.00, "Spray com fragrância deliciosa para seus lençóis e cortinas", "homespray.jpg", null));
            produtos.Add(new Product(4, "Sabonete líquido", (decimal)20.00, "Sabonete Líquido preparado com a sua fragrância favorita e hidratação excelente", "saboneteliquido.jpg", null));

            return View(produtos);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
