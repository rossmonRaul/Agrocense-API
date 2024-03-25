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

        [HttpGet]
        public async Task<JsonResult> ObtenerRotacionCultivoSegunEstacionalidad()
        {
            return Json(await this.servicioCultivos.ObtenerRotacionCultivoSegunEstacionalidad());
        }

        [HttpPost]
        public async Task<JsonResult> CrearProductividadCultivo(EntityProductividadCultivo entityProductividadCultivo)
        {
            return Json(await this.servicioCultivos.CrearProductividadCultivo(entityProductividadCultivo));
        }
        [HttpPost]
        public async Task<JsonResult> InsertarRotacionCultivoSegunEstacionalidad(EntityRotacionCultivos entityRotacionCultivos)
        {
            return Json(await this.servicioCultivos.InsertarRotacionCultivoSegunEstacionalidad(entityRotacionCultivos));
        }


        [HttpPut]
        public async Task<JsonResult> ActualizarProductividadCultivo(EntityProductividadCultivo entityProductividadCultivo)
        {
            return Json(await this.servicioCultivos.ActualizarProductividadCultivo(entityProductividadCultivo));
        }


        [HttpPut]
        public async Task<JsonResult> ModificarRotacionCultivoSegunEstacionalidad(EntityRotacionCultivos entityRotacionCultivos)
        {
            return Json(await this.servicioCultivos.ModificarRotacionCultivoSegunEstacionalidad(entityRotacionCultivos));
        }

        [HttpPut]
        public async Task<JsonResult> CambiarEstadoProductividadCultivo(EntityProductividadCultivo entityProductividadCultivo)
        {
            return Json(await this.servicioCultivos.CambiarEstadoProductividadCultivo(entityProductividadCultivo));
        }
        [HttpPut]
        public async Task<JsonResult> CambiarEstadoRotacionCultivo(EntityRotacionCultivos entityRotacionCultivos)
        {
            return Json(await this.servicioCultivos.CambiarEstadoRotacionCultivo(entityRotacionCultivos));
        }
    }
}
