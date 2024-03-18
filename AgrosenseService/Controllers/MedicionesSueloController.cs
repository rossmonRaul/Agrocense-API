using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Empresa;
using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Suelo;
using Agrosense.Service.Model.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Agrosense.Service.Controllers
{

    [ApiController]
    [Route("api/v1.0/[controller]/[action]")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Produces("application/json")]
    public class MedicionesSueloController : Controller
    {
        private readonly IServicioMedicionesSuelo servicioMedicionesSuelo;

        public MedicionesSueloController(IServicioMedicionesSuelo servicioMedicionesSuelo)
        {
            this.servicioMedicionesSuelo = servicioMedicionesSuelo;
        }

        [HttpGet]
        public async Task<JsonResult> ObtenerDatosMedicionesSuelo()
        {
            return Json(await this.servicioMedicionesSuelo.ObtenerDatosMedicionesSuelo());
        }
        [HttpPost]
        public async Task<JsonResult> InsertarMedicionesSuelo(EntityMedicionesSuelo entityMedicionesSuelo)
        {
            return Json(await this.servicioMedicionesSuelo.InsertarMedicionesSuelo(entityMedicionesSuelo));
        }
        [HttpPut]
        public async Task<JsonResult> ModificarMedicionesSuelo(EntityMedicionesSuelo entityMedicionesSuelo)
        {
            return Json(await this.servicioMedicionesSuelo.ModificarMedicionesSuelo(entityMedicionesSuelo));
        }
        [HttpPut]
        public async Task<JsonResult> CambiarEstadoMedicionesSuelo(EntityMedicionesSuelo entityMedicionesSuelo)
        {
            return Json(await this.servicioMedicionesSuelo.CambiarEstadoMedicionesSuelo(entityMedicionesSuelo));
        }
    }
}
