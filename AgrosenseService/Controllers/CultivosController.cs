﻿using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Cultivos;
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
    public class CultivosController : Controller
    {
        private readonly IServicioCultivos servicioCultivos;

        public CultivosController(IServicioCultivos servicioCultivos)
        {
            this.servicioCultivos = servicioCultivos;
        }

        [HttpGet]
        public async Task<JsonResult> ObtenerCalidadCultivo()
        {
            return Json(await this.servicioCultivos.ObtenerCalidadCultivo());
        }

        [HttpPost]
        public async Task<JsonResult> CrearCalidadCultivo(EntityCalidadCultivo entityCalidadCultivo)
        {
            return Json(await this.servicioCultivos.CrearCalidadCultivo(entityCalidadCultivo));
        }

        [HttpPut]
        public async Task<JsonResult> ActualizarCalidadCultivo(EntityCalidadCultivo entityCalidadCultivo)
        {
            return Json(await this.servicioCultivos.ActualizarCalidadCultivo(entityCalidadCultivo));
        }

        [HttpPut]
        public async Task<JsonResult> CambiarEstadoCalidadCultivo(EntityCalidadCultivo entityCalidadCultivo)
        {
            return Json(await this.servicioCultivos.CambiarEstadoCalidadCultivo(entityCalidadCultivo));
        }
    }
}
