using Agrosense.Service.BusinessLogic.Interface.Aplicacion.UsoAgua;
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
    public class UsoAguaController : Controller
    {
        private readonly IServicioUsoAgua servicioUsoAgua; // Suponiendo que tienes un servicio llamado RegistroSeguimientoUsoAguaService

        public UsoAguaController(IServicioUsoAgua servicioUsoAgua)
        {
            this.servicioUsoAgua = servicioUsoAgua;
        }

        [HttpGet]
        public async Task<JsonResult> ObtenerUsoAgua()
        {
            return Json(await this.servicioUsoAgua.ObtenerRegistrosSeguimientoUsoAgua());
        }

        [HttpPost]
        public async Task<JsonResult> CrearRegistroSeguimientoUsoAgua(EntityUsoAgua entityUsoAgua)
        {
            return Json(await this.servicioUsoAgua.CrearRegistroSeguimientoUsoAgua(entityUsoAgua));
        }

        [HttpPut]
        public async Task<JsonResult> ActualizarRegistroSeguimientoUsoAgua(EntityUsoAgua entityUsoAgua)
        {
            return Json(await this.servicioUsoAgua.ActualizarRegistroSeguimientoUsoAgua(entityUsoAgua));
        }

        [HttpPut]
        public async Task<JsonResult> CambiarEstadoRegistroSeguimientoUsoAgua(EntityUsoAgua entityUsoAgua)
        {
            return Json(await this.servicioUsoAgua.CambiarEstadoRegistroSeguimientoUsoAgua(entityUsoAgua));
        }
    }
}
