using MVCPETSHOP.Models;
using MVCPETSHOP.Servicios;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCPETSHOP.Controllers
{
    public class PerfilMascotasController : Controller
    {
        private readonly IRepositorioPerfilMascotas RepositorioPerfilMascotas;

        public PerfilMascotasController(IRepositorioPerfilMascotas repositorioPerfilMascotas)
        {
            this.RepositorioPerfilMascotas = repositorioPerfilMascotas;
        }

        [HttpGet]
        public async Task<IActionResult> Crear()
        {
            var IdMascotas = RepositorioPerfilMascotas.ObtenerPorId();
            await Obtener(IdMascotas);
            var Raza = new PerfilMascotas();

            return View();
        }

        private async Task Obtener(object IdMascotas)
        {
            await RepositorioPerfilMascotas.Obtener(IdMascotas);
        }
    }
}
