using Microsoft.AspNetCore.Mvc;
using MVCPETSHOP.Models;
using System.Diagnostics;

namespace MVCPETSHOP.Controllers
{
    public class HomeController : Controller
    {
     
      

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel loginDataModel)
        {
            if (ModelState.IsValid)
            {
                // AQUÍ EL CÓDIGO DE VALIDACIÓN DEL USUARIO
                return RedirectToAction("LoginOk");
            }
            else
            {
                return View(loginDataModel);
            }
        }

        public ActionResult LoginOK()
        {
            // LA VALIDACIÓN DEL USUARIO HA SIDO CORRECTA
            return View("Privacy");
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        
        public ActionResult Pedido()
        {
            
            
                // AQUÍ EL CÓDIGO DE VALIDACIÓN DEL USUARIO
                return View("Pedido");
         }

        public ActionResult Mascota()
        {


            // AQUÍ EL CÓDIGO DE VALIDACIÓN DEL USUARIO
            return View("Mascota");
        }

        public ActionResult Crear()
        {


            // AQUÍ EL CÓDIGO DE VALIDACIÓN DEL USUARIO
            return View("Crear");
        }



      

    }


}

