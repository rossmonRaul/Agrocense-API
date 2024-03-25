using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Fertilizantes;
using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Residuos;
using Agrosense.Service.Model.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Agrosense.Service.Controllers
{
    [ApiController]
    [Route("api/v1.0/[controller]/[action]")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Produces("application/json")]
    public class ResiduoController : Controller
    {
        private readonly IServicioManejoResiduos servicioManejoResiduo;

        public ResiduoController(IServicioManejoResiduos servicioManejoResiduo)
        {
            this.servicioManejoResiduo = servicioManejoResiduo;
        }

        [HttpGet]
        public async Task<JsonResult> ObtenerManejoResiduos()
        {
            return Json(await this.servicioManejoResiduo.ObtenerManejoResiduos());
        }

        [HttpPost]
        public async Task<JsonResult> InsertarManejoResiduos(EntityManejoResiduos entityManejoResiduos)
        {
            return Json(await this.servicioManejoResiduo.InsertarManejoResiduos(entityManejoResiduos));
        }

        [HttpPut]
        public async Task<JsonResult> ActualizarManejoResiduos(EntityManejoResiduos entityManejoResiduos)
        {
            return Json(await this.servicioManejoResiduo.ActualizarManejoResiduos(entityManejoResiduos));
        }

        [HttpPut]
        public async Task<JsonResult> CambiarEstadoManejoResiduos(EntityManejoResiduos entityManejoResiduos)
        {
            return Json(await this.servicioManejoResiduo.CambiarEstadoManejoResiduos(entityManejoResiduos));
        }

    }
}
