using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Suelo;
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
    public class ServicioMedicionesSuelo : IServicioMedicionesSuelo
    {
        private readonly IRepositorioMedicionesSuelo repositorioMedicionesSuelo;

        public ServicioMedicionesSuelo(IRepositorioMedicionesSuelo repositorioMedicionesSuelo)
        {
            this.repositorioMedicionesSuelo = repositorioMedicionesSuelo;
        }

        public async Task<List<DtoMedicionesSuelo>> ObtenerDatosMedicionesSuelo()
        {
            return await this.repositorioMedicionesSuelo.ObtenerDatosMedicionesSuelo();
        }
        public async Task<DtoRespuestaSP> InsertarMedicionesSuelo(EntityMedicionesSuelo entityMedicionesSuelo){
            return await this.repositorioMedicionesSuelo.InsertarMedicionesSuelo(entityMedicionesSuelo);
        }
        public async Task<DtoRespuestaSP> ModificarMedicionesSuelo(EntityMedicionesSuelo entityMedicionesSuelo)
        {
            return await this.repositorioMedicionesSuelo.ModificarMedicionesSuelo(entityMedicionesSuelo);
        }
        public async Task<DtoRespuestaSP> CambiarEstadoMedicionesSuelo(EntityMedicionesSuelo entityMedicionesSuelo)
        {
            return await this.repositorioMedicionesSuelo.CambiarEstadoMedicionesSuelo(entityMedicionesSuelo);
        }
    }
}
