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

        public async Task<List<DtoCalidadCultivo>> ObtenerCalidadCultivo()
        {
            return await this.repositorioCultivos.ObtenerCalidadCultivo();
        }
        public async Task<List<DtoRotacionCultivos>> ObtenerRotacionCultivoSegunEstacionalidad()
        {
            return await this.repositorioCultivos.ObtenerRotacionCultivoSegunEstacionalidad();
        }
        public async Task<DtoRespuestaSP> CrearCalidadCultivo(EntityCalidadCultivo entityCalidadCultivo)
        {
            return await this.repositorioCultivos.CrearCalidadCultivo(entityCalidadCultivo);
        }
        public async Task<DtoRespuestaSP> InsertarRotacionCultivoSegunEstacionalidad(EntityRotacionCultivos entityRotacionCultivos)
        {
            return await this.repositorioCultivos.InsertarRotacionCultivoSegunEstacionalidad(entityRotacionCultivos);
        }
        public async Task<DtoRespuestaSP> ActualizarCalidadCultivo(EntityCalidadCultivo entityCalidadCultivo)
        {
            return await this.repositorioCultivos.ActualizarCalidadCultivo(entityCalidadCultivo);
        }
        public async Task<DtoRespuestaSP> ModificarRotacionCultivoSegunEstacionalidad(EntityRotacionCultivos entityRotacionCultivos)
        {
            return await this.repositorioCultivos.ModificarRotacionCultivoSegunEstacionalidad(entityRotacionCultivos);
        }
        public async Task<DtoRespuestaSP> CambiarEstadoCalidadCultivo(EntityCalidadCultivo entityCalidadCultivo)
        {
            return await this.repositorioCultivos.CambiarEstadoCalidadCultivo(entityCalidadCultivo);
        }
        public async Task<DtoRespuestaSP> CambiarEstadoRotacionCultivo(EntityRotacionCultivos entityRotacionCultivos)
        {
            return await this.repositorioCultivos.CambiarEstadoRotacionCultivo(entityRotacionCultivos);
        }

    }
}
