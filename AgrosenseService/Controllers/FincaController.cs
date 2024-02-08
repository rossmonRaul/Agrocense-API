using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Finca;
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
    }
}
