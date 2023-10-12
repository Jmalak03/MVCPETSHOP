using Microsoft.AspNetCore.Mvc;
using MVCPETSHOP.Models;

namespace MVCPETSHOP.Controllers
{
    public class Catalogo : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(CatalogoModel catalogodata)
        {
            if (ModelState.IsValid)
            {
                // AQUÍ EL CÓDIGO DE VALIDACIÓN DEL USUARIO
                return RedirectToAction("Agregaralcarrito");
            }
            else
            {
                return View(catalogodata);
            }
        }

        public ActionResult Agregaralcarrito()
        {
            // LA VALIDACIÓN DEL USUARIO HA SIDO CORRECTA
            return View("Privacy");
        }


    }
}
