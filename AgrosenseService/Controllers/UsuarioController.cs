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
        public async Task<JsonResult> ObtenerUsuariosPorRol2()
        {
            return Json(await this.servicioUsuario.ObtenerUsuariosPorRol2());
        }
        [HttpPost]
        public async Task<JsonResult> ObtenerUsuariosPorRol3(EntityUsuario entityUsuario)
        {
            return Json(await this.servicioUsuario.ObtenerUsuariosPorRol3(entityUsuario));
        }
        [HttpGet]
        public async Task<JsonResult> ObtenerUsuariosPorRol4()
        {
            return Json(await this.servicioUsuario.ObtenerUsuariosPorRol4());
        }

        [HttpPost]
        public async Task<JsonResult> InsertarUsuario(EntityUsuario entityUsuario)
        {
            return Json(await this.servicioUsuario.InsertarUsuario(entityUsuario));
        }
        [HttpPost]
        public async Task<JsonResult> GuardarUsuarioPorSuperUsuario(EntityUsuario entityUsuario)
        {
            return Json(await this.servicioUsuario.GuardarUsuarioPorSuperUsuario(entityUsuario));
        }
        [HttpPut]
        public async Task<JsonResult> ActualizarUsuario(EntityUsuario entityUsuario)
        {
            return Json(await this.servicioUsuario.ActualizarUsuario(entityUsuario));
        }
        [HttpPut]
        public async Task<JsonResult> ActualizarUsuarioAdministrador(EntityUsuario entityUsuario)
        {
            return Json(await this.servicioUsuario.ActualizarUsuarioAdministrador(entityUsuario));
        }
        [HttpPost]
        public async Task<JsonResult> ValidarUsuario(EntityUsuario entityUsuario)
        {
            return Json(await this.servicioUsuario.ValidarUsuario(entityUsuario));
        }

        [HttpPut]
        public async Task<JsonResult> CambioEstadoUsuario(EntityUsuario entityUsuario)
        {
            return Json(await this.servicioUsuario.CambioEstadoUsuario(entityUsuario));
        }

    }
}
