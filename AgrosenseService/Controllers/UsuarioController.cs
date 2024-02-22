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
        [HttpPost]
        public async Task<JsonResult> ObtenerUsuariosPorIdEmpresa(EntityUsuario entityUsuario)
        {
            return Json(await this.servicioUsuario.ObtenerUsuariosPorIdEmpresa(entityUsuario));
        }
        
        [HttpGet]
        public async Task<JsonResult> ObtenerUsuariosPorRol4()
        {
            return Json(await this.servicioUsuario.ObtenerUsuariosPorRol4());
        }

        [HttpPost]
        public async Task<JsonResult> GuardarUsuario(EntityUsuario entityUsuario)
        {
            return Json(await this.servicioUsuario.GuardarUsuario(entityUsuario));
        }
        [HttpPost]
        public async Task<JsonResult> GuardarUsuarioPorSuperUsuario(EntityUsuario entityUsuario)
        {
            return Json(await this.servicioUsuario.GuardarUsuarioPorSuperUsuario(entityUsuario));
        }
        //[HttpPut]
        //public async Task<JsonResult> ActualizarUsuarioNOENUSO(EntityUsuario entityUsuario)
        //{
        //    return Json(await this.servicioUsuario.ActualizarUsuarioNOENUSO(entityUsuario));
        //}
        //[HttpPut]
        //public async Task<JsonResult> ActualizarUsuarioSinEmpresa(EntityUsuario entityUsuario)
        //{
        //    return Json(await this.servicioUsuario.ActualizarUsuarioSinEmpresa(entityUsuario));
        //}
        [HttpPut]
        public async Task<JsonResult> ActualizarUsuarioAdministrador(EntityUsuario entityUsuario)
        {
            return Json(await this.servicioUsuario.ActualizarUsuarioAdministrador(entityUsuario));
        }
        [HttpPut]
        public async Task<JsonResult> ActualizarContrasenaUsuario(EntityUsuario entityUsuario)
        {
            return Json(await this.servicioUsuario.ActualizarContrasenaUsuario(entityUsuario));
        }
        [HttpPut]
        public async Task<JsonResult> AsignarFincaParcela(EntityUsuario entityUsuario)
        {
            return Json(await this.servicioUsuario.AsignarFincaParcela(entityUsuario));
        }
        [HttpPut]
        public async Task<JsonResult> AsignarEmpresaFincaYParcela(EntityUsuario entityUsuario)
        {
            return Json(await this.servicioUsuario.AsignarEmpresaFincaYParcela(entityUsuario));
        }
        [HttpPut]
        public async Task<JsonResult> AsignarNuevaFincaParcela(EntityUsuario entityUsuario)
        {
            return Json(await this.servicioUsuario.AsignarNuevaFincaParcela(entityUsuario));
        }
        [HttpPost]
        public async Task<JsonResult> ValidarUsuario(EntityUsuario entityUsuario)
        {
            return Json(await this.servicioUsuario.ValidarUsuario(entityUsuario));
        }

        [HttpPut]
        public async Task<JsonResult> CambiarEstadoUsuarioFincaParcela(EntityUsuario entityUsuario)
        {
            return Json(await this.servicioUsuario.CambiarEstadoUsuarioFincaParcela(entityUsuario));
        }
        [HttpPut]
        public async Task<JsonResult> CambiarEstadoUsuario(EntityUsuario entityUsuario)
        {
            return Json(await this.servicioUsuario.CambiarEstadoUsuario(entityUsuario));
        }

    }
}
