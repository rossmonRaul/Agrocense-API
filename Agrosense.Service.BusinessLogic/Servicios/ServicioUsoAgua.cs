using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Cultivos;
using Agrosense.Service.BusinessLogic.Interface.Aplicacion.UsoAgua;
using Agrosense.Service.DataAccess.Interface.Infraestructura;
using Agrosense.Service.Model.Dto;
using Agrosense.Service.Model.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Agrosense.Service.BusinessLogic.Servicios
{
    public class ServicioUsoAgua : IServicioUsoAgua
    {
        private readonly IRepositorioUsoAgua repositorioUsoAgua;

        public ServicioUsoAgua(IRepositorioUsoAgua repositorioRegistroSeguimientoUsoAgua)
        {
            this.repositorioUsoAgua = repositorioRegistroSeguimientoUsoAgua;
        }

        public async Task<List<DtoUsoAgua>> ObtenerRegistrosSeguimientoUsoAgua()
        {
            return await this.repositorioUsoAgua.ObtenerRegistrosSeguimientoUsoAgua();
        }

        public async Task<DtoRespuestaSP> ActualizarRegistroSeguimientoUsoAgua(EntityUsoAgua entityUsoAgua)
        {
            return await this.repositorioUsoAgua.ActualizarRegistroSeguimientoUsoAgua(entityUsoAgua);
        }

        public async Task<DtoRespuestaSP> CambiarEstadoRegistroSeguimientoUsoAgua(EntityUsoAgua entityUsoAgua)
        {
            return await this.repositorioUsoAgua.CambiarEstadoRegistroSeguimientoUsoAgua(entityUsoAgua);
        }

        public async Task<DtoRespuestaSP> CrearRegistroSeguimientoUsoAgua(EntityUsoAgua entityUsoAgua)
        {
            return await this.repositorioUsoAgua.CrearRegistroSeguimientoUsoAgua(entityUsoAgua);
        }

    }
}
