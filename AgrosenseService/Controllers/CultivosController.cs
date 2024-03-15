using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Cultivos;
using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Empresa;
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

       
    }
}
