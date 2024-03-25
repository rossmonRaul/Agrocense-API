using Agrosense.Service.Model.Dto;
using Agrosense.Service.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.BusinessLogic.Interface.Aplicacion.PreparacionTerreno
{
    public interface IServicioPreparacionTerreno
    {
        Task<List<DtoPreparacionTerreno>> ObtenerDatosPreparacionTerreno();
        Task<DtoRespuestaSP> InsertarPreparacionTerreno(EntityPreparacionTerreno entityPreparacionTerreno);
        Task<DtoRespuestaSP> ModificarPreparacionTerreno(EntityPreparacionTerreno entityPreparacionTerreno);
        Task<DtoRespuestaSP> CambiarEstadoPreparacionTerreno(EntityPreparacionTerreno entityPreparacionTerreno);
    }
}
