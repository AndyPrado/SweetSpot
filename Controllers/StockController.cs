using Microsoft.AspNetCore.Mvc;

namespace SweetSpot.Controllers
{
    public class StockController : Controller
    {
        public IActionResult Index(){

            return View();
        }  
    }
}