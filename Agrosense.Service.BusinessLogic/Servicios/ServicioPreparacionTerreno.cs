using Agrosense.Service.BusinessLogic.Interface.Aplicacion.PreparacionTerreno;
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
    public class ServicioPreparacionTerreno : IServicioPreparacionTerreno
    {
        private readonly IRepositorioPreparacionTerreno repositorioPreparacionTerreno;

        public ServicioPreparacionTerreno(IRepositorioPreparacionTerreno repositorioPreparacionTerreno)
        {
            this.repositorioPreparacionTerreno = repositorioPreparacionTerreno;
        }

        public async Task<List<DtoPreparacionTerreno>> ObtenerDatosPreparacionTerreno()
        {
            return await this.repositorioPreparacionTerreno.ObtenerDatosPreparacionTerreno();
        }
        public async Task<DtoRespuestaSP> InsertarPreparacionTerreno(EntityPreparacionTerreno entityPreparacionTerreno)
        {
            return await this.repositorioPreparacionTerreno.InsertarPreparacionTerreno(entityPreparacionTerreno);
        }

        public async Task<DtoRespuestaSP> ModificarPreparacionTerreno(EntityPreparacionTerreno entityPreparacionTerreno)
        {
            return await this.repositorioPreparacionTerreno.ModificarPreparacionTerreno(entityPreparacionTerreno);
        }

        public async Task<DtoRespuestaSP> CambiarEstadoPreparacionTerreno(EntityPreparacionTerreno entityPreparacionTerreno)
        {
            return await this.repositorioPreparacionTerreno.CambiarEstadoPreparacionTerreno(entityPreparacionTerreno);
        }
    }
}
