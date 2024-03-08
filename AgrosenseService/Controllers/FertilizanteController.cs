using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Empresa;
using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Fertilizantes;
using Agrosense.Service.Model.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Agrosense.Service.Controllers
{

    [ApiController]
    [Route("api/v1.0/[controller]/[action]")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Produces("application/json")]
    public class FertilizanteController : Controller
    {
        private readonly IServicioManejoFertilizantes servicioManejoFertilizantes;

        public FertilizanteController(IServicioManejoFertilizantes servicioManejoFertilizantes)
        {
            this.servicioManejoFertilizantes = servicioManejoFertilizantes;
        }

        [HttpGet]
        public async Task<JsonResult> ObtenerManejoFertilizantes()
        {
            return Json(await this.servicioManejoFertilizantes.ObtenerManejoFertilizantes());
        }

        [HttpPost]
        public async Task<JsonResult> InsertarManejoFertilizantes(EntityManejoFertilizantes entityManejoFertilizantes)
        {
            return Json(await this.servicioManejoFertilizantes.InsertarManejoFertilizantes(entityManejoFertilizantes));
        }

        [HttpPut]
        public async Task<JsonResult> ActualizarManejoFertilizantes(EntityManejoFertilizantes entityManejoFertilizantes)
        {
            return Json(await this.servicioManejoFertilizantes.ActualizarManejoFertilizantes(entityManejoFertilizantes));
        }

    }
}
