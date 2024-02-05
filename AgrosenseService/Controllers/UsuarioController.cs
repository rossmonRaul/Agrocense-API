using Microsoft.AspNetCore.Mvc;
using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Usuario;
using Agrosense.Service.Model.Entity;


namespace AgrosenseService.Controllers
{
    /*[Route("{controller}")]
    [ApiController]*/
    [ApiController]
    //[Route("[controller]")]
    [Route("api/v1.0/[controller]/[action]")]
   // [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Produces("application/json")]
    public class UsuarioController: Controller
    {
        private readonly IServicioUsuario servicioUsuario;

        public UsuarioController(IServicioUsuario servicioUsuario)
        {
            this.servicioUsuario = servicioUsuario;
        }


        //[HttpGet("[action]")]
        [HttpGet]
        public async Task<JsonResult> ObtenerUsuarios()
        {
            return Json(await this.servicioUsuario.ObtenerUsuarios());
        }

        [HttpPost]
        public async Task<JsonResult> InsertarUsuario(EntityUsuario entityUsuario)
        {
            return Json(await this.servicioUsuario.InsertarUsuario(entityUsuario));
        }

    }
}
