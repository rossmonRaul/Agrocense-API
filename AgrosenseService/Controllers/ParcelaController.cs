using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Parcela;
using Microsoft.AspNetCore.Mvc;

namespace Agrosense.Service.Controllers
{
    [ApiController]
    [Route("api/v1.0/[controller]/[action]")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Produces("application/json")]
    public class ParcelaController : Controller
    {
        private readonly IServicioParcela servicioParcela;

        public ParcelaController(IServicioParcela servicioParcela)
        {
            this.servicioParcela = servicioParcela;
        }

        [HttpGet]
        public async Task<JsonResult> ObtenerParcelas()
        {
            return Json(await this.servicioParcela.ObtenerParcelas());
        }
    }
}
