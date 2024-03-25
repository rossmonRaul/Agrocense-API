using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Cultivos;
using Agrosense.Service.DataAccess.Interface.Infraestructura;
using Agrosense.Service.Model.Dto;
using Agrosense.Service.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.BusinessLogic.Servicios
{
    public class ServicioCultivos: IServicioCultivos
    {
        private readonly IRepositorioCultivos repositorioCultivos;

        public ServicioCultivos(IRepositorioCultivos repositorioCultivos)
        {
            this.repositorioCultivos = repositorioCultivos;
        }

        public async Task<List<DtoProductividadCultivo>> ObtenerProductividadCultivo()
        {
            return await this.repositorioCultivos.ObtenerProductividadCultivo();
        }
        public async Task<DtoRespuestaSP> CrearProductividadCultivo(EntityProductividadCultivo entityProductividadCultivo)
        {
            return await this.repositorioCultivos.CrearProductividadCultivo(entityProductividadCultivo);
        }
        public async Task<DtoRespuestaSP> ActualizarProductividadCultivo(EntityProductividadCultivo entityProductividadCultivo)
        {
            return await this.repositorioCultivos.ActualizarProductividadCultivo(entityProductividadCultivo);
        }
        public async Task<DtoRespuestaSP> CambiarEstadoProductividadCultivo(EntityProductividadCultivo entityProductividadCultivo)
        {
            return await this.repositorioCultivos.CambiarEstadoProductividadCultivo(entityProductividadCultivo);
        }

    }
}
