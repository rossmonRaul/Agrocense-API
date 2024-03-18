using Agrosense.Service.Model.Dto;
using Agrosense.Service.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.BusinessLogic.Interface.Aplicacion.Suelo
{
    public interface IServicioMedicionesSuelo
    {
        Task<List<DtoMedicionesSuelo>> ObtenerDatosMedicionesSuelo();
        Task<DtoRespuestaSP> InsertarMedicionesSuelo(EntityMedicionesSuelo entityMedicionesSuelo);
        Task<DtoRespuestaSP> ModificarMedicionesSuelo(EntityMedicionesSuelo entityMedicionesSuelo);
        Task<DtoRespuestaSP> CambiarEstadoMedicionesSuelo(EntityMedicionesSuelo entityMedicionesSuelo);
    }
}
