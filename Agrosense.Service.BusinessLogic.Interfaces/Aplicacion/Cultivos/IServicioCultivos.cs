﻿using Agrosense.Service.Model.Dto;
using Agrosense.Service.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.BusinessLogic.Interface.Aplicacion.Cultivos
{
    public interface IServicioCultivos
    {
        Task<List<DtoProductividadCultivo>> ObtenerProductividadCultivo();
        Task<DtoRespuestaSP> CrearProductividadCultivo(EntityProductividadCultivo entityProductividadCultivo);
        Task<DtoRespuestaSP> ActualizarProductividadCultivo(EntityProductividadCultivo entityProductividadCultivo);
        Task<DtoRespuestaSP> CambiarEstadoProductividadCultivo(EntityProductividadCultivo entityProductividadCultivoo);
    }
}
