using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Finca;
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
    public class ServicioFinca:IServicioFinca
    {
        private readonly IRepositorioFinca repositorioFinca;

        public ServicioFinca(IRepositorioFinca repositorioFinca)
        {
            this.repositorioFinca = repositorioFinca;
        }

        public async Task<List<DtoFinca>> ObtenerFincas()
        {
            return await this.repositorioFinca.ObtenerFincas();
        }
        public async Task<DtoRespuestaSP> CrearFinca(EntityFinca entityFinca)
        {
            return await this.repositorioFinca.CrearFinca(entityFinca);
        }
        public async Task<DtoRespuestaSP> ActualizarFinca(EntityFinca entityFinca)
        {
            return await this.repositorioFinca.ActualizarFinca(entityFinca);
        }
        public async Task<DtoRespuestaSP> CambiarEstadoFinca(EntityFinca entityFinca)
        {
            return await this.repositorioFinca.CambiarEstadoFinca(entityFinca);
        }
    }
}
