using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Parcela;
using Agrosense.Service.Model.Entity;
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
        [HttpPost]
        public async Task<JsonResult> CrearParcela(EntityParcela entityParcela)
        {
            return Json(await this.servicioParcela.CrearParcela(entityParcela));
        }
        [HttpPut]
        public async Task<JsonResult> ActualizarParcela(EntityParcela entityParcela)
        {
            return Json(await this.servicioParcela.ActualizarParcela(entityParcela));
        }
        [HttpPut]
        public async Task<JsonResult> CambiarEstadoParcela(EntityParcela entityParcela)
        {
            return Json(await this.servicioParcela.CambiarEstadoParcela(entityParcela));
        }
    }
}
