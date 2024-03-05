using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Finca;
using Agrosense.Service.Model.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Agrosense.Service.Controllers
{
    [ApiController]
    [Route("api/v1.0/[controller]/[action]")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Produces("application/json")]
    public class FincaController : Controller
    {
        private readonly IServicioFinca servicioFinca;

        public FincaController(IServicioFinca servicioFinca)
        {
            this.servicioFinca = servicioFinca;
        }

        [HttpGet]
        public async Task<JsonResult> ObtenerFincas()
        {
            return Json(await this.servicioFinca.ObtenerFincas());
        }
        [HttpPost]
        public async Task<JsonResult> CrearFinca(EntityFinca entityFinca)
        {
            return Json(await this.servicioFinca.CrearFinca(entityFinca));
        }
        [HttpPut]
        public async Task<JsonResult> ActualizarFinca(EntityFinca entityFinca)
        {
            return Json(await this.servicioFinca.ActualizarFinca(entityFinca));
        }
        [HttpPut]
        public async Task<JsonResult> CambiarEstadoFinca(EntityFinca entityFinca)
        {
            return Json(await this.servicioFinca.CambiarEstadoFinca(entityFinca));
        }
    }
}
