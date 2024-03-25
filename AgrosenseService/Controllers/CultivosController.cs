using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Cultivos;
using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Empresa;
using Agrosense.Service.Model.Dto;
using Agrosense.Service.Model.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Agrosense.Service.Controllers
{

    [ApiController]
    [Route("api/v1.0/[controller]/[action]")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Produces("application/json")]
    public class CultivosController : Controller
    {
        private readonly IServicioCultivos servicioCultivos;

        public CultivosController(IServicioCultivos servicioCultivos)
        {
            this.servicioCultivos = servicioCultivos;
        }

        [HttpGet]
        public async Task<JsonResult> ObtenerProductividadCultivo()
        {
            return Json(await this.servicioCultivos.ObtenerProductividadCultivo());
        }

        [HttpPost]
        public async Task<JsonResult> CrearProductividadCultivo(EntityProductividadCultivo entityProductividadCultivo)
        {
            return Json(await this.servicioCultivos.CrearProductividadCultivo(entityProductividadCultivo));
        }

        [HttpPut]
        public async Task<JsonResult> ActualizarProductividadCultivo(EntityProductividadCultivo entityProductividadCultivo)
        {
            return Json(await this.servicioCultivos.ActualizarProductividadCultivo(entityProductividadCultivo));
        }

        [HttpPut]
        public async Task<JsonResult> CambiarEstadoProductividadCultivo(EntityProductividadCultivo entityProductividadCultivo)
        {
            return Json(await this.servicioCultivos.CambiarEstadoProductividadCultivo(entityProductividadCultivo));
        }
    }
}
