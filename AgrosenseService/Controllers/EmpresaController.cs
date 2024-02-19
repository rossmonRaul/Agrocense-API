﻿using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Empresa;
using Agrosense.Service.Model.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Agrosense.Service.Controllers
{

    [ApiController]
    [Route("api/v1.0/[controller]/[action]")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Produces("application/json")]
    public class EmpresaController : Controller
    {
        private readonly IServicioEmpresa servicioEmpresa;

        public EmpresaController(IServicioEmpresa servicioEmpresa)
        {
            this.servicioEmpresa = servicioEmpresa;
        }

        [HttpGet]
        public async Task<JsonResult> ObtenerEmpresas()
        {
            return Json(await this.servicioEmpresa.ObtenerEmpresas());
        }
        [HttpPost]
        public async Task<JsonResult> InsertarEmpresa(EntityEmpresa entityEmpresa)
        {
            return Json(await this.servicioEmpresa.InsertarEmpresa(entityEmpresa));
        }
    }
}
