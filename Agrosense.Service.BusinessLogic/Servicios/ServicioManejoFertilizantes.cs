using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Fertilizantes;
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
    public class ServicioManejoFertilizantes : IServicioManejoFertilizantes
    {
        private readonly IRepositorioManejoFertilizantes repositorioManejoFertilizantes;

        public ServicioManejoFertilizantes(IRepositorioManejoFertilizantes repositorioManejoFertilizantes)
        {
            this.repositorioManejoFertilizantes = repositorioManejoFertilizantes;
        }

        public async Task<List<DtoManejoFertilizantes>> ObtenerManejoFertilizantes()
        {
            return await this.repositorioManejoFertilizantes.ObtenerManejoFertilizantes();
        }
        public async Task<DtoRespuestaSP> InsertarManejoFertilizantes(EntityManejoFertilizantes entityManejoFertilizantes)
        {
            return await this.repositorioManejoFertilizantes.InsertarManejoFertilizantes(entityManejoFertilizantes);
        }

        public async Task<DtoRespuestaSP> ActualizarManejoFertilizantes(EntityManejoFertilizantes entityManejoFertilizantes)
        {
            return await this.repositorioManejoFertilizantes.ActualizarManejoFertilizantes(entityManejoFertilizantes);
        }

        public async Task<DtoRespuestaSP> CambiarEstadoManejoFertilizantes(EntityManejoFertilizantes entityManejoFertilizantes)
        {
            return await this.repositorioManejoFertilizantes.CambiarEstadoManejoFertilizantes(entityManejoFertilizantes);
        }
    }
}
