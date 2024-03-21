using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Empresa;
using Agrosense.Service.BusinessLogic.Interface.Aplicacion.PreparacionTerreno;
using Agrosense.Service.Model.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Agrosense.Service.Controllers
{

    [ApiController]
    [Route("api/v1.0/[controller]/[action]")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Produces("application/json")]
    public class PreparacionTerrenoController : Controller
    {
        private readonly IServicioPreparacionTerreno servicioPreparacionTerreno;

        public PreparacionTerrenoController(IServicioPreparacionTerreno servicioPreparacionTerreno)
        {
            this.servicioPreparacionTerreno = servicioPreparacionTerreno;
        }

        [HttpGet]
        public async Task<JsonResult> ObtenerDatosPreparacionTerreno()
        {
            return Json(await this.servicioPreparacionTerreno.ObtenerDatosPreparacionTerreno());
        }
        [HttpPost]
        public async Task<JsonResult> InsertarPreparacionTerreno(EntityPreparacionTerreno entityPreparacionTerreno)
        {
            return Json(await this.servicioPreparacionTerreno.InsertarPreparacionTerreno(entityPreparacionTerreno));
        }
        [HttpPut]
        public async Task<JsonResult> ModificarPreparacionTerreno(EntityPreparacionTerreno entityPreparacionTerreno)
        {
            return Json(await this.servicioPreparacionTerreno.ModificarPreparacionTerreno(entityPreparacionTerreno));
        }
        [HttpPut]
        public async Task<JsonResult> CambiarEstadoPreparacionTerreno(EntityPreparacionTerreno entityPreparacionTerreno)
        {
            return Json(await this.servicioPreparacionTerreno.CambiarEstadoPreparacionTerreno(entityPreparacionTerreno));
        }
    }
}
