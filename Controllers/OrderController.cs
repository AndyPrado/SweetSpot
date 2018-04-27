using Microsoft.AspNetCore.Mvc;

namespace SweetSpot.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index(){

            return View();
        }    

        public IActionResult Add(){
            
            return View();
        }
    }
}