using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Fertilizantes;
using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Residuos;
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
    public class ServicioManejoResiduos : IServicioManejoResiduos
    {
        private readonly IRepositorioManejoResiduos repositorioManejoResiduos;

        public ServicioManejoResiduos(IRepositorioManejoResiduos repositorioManejoResiduos)
        {
            this.repositorioManejoResiduos = repositorioManejoResiduos;
        }

        public async Task<List<DtoManejoResiduos>> ObtenerManejoResiduos()
        {
            return await this.repositorioManejoResiduos.ObtenerManejoResiduos();
        }
        public async Task<DtoRespuestaSP> InsertarManejoResiduos(EntityManejoResiduos entityManejoResiduos)
        {
            return await this.repositorioManejoResiduos.InsertarManejoResiduos(entityManejoResiduos);
        }

        public async Task<DtoRespuestaSP> ActualizarManejoResiduos(EntityManejoResiduos entityManejoResiduos)
        {
            return await this.repositorioManejoResiduos.ActualizarManejoResiduos(entityManejoResiduos);
        }

        public async Task<DtoRespuestaSP> CambiarEstadoManejoResiduos(EntityManejoResiduos entityManejoResiduos)
        {
            return await this.repositorioManejoResiduos.CambiarEstadoManejoResiduos(entityManejoResiduos);
        }
    }
}
