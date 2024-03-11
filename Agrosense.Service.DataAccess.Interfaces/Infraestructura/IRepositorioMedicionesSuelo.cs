using Agrosense.Service.Model.Dto;
using Agrosense.Service.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.DataAccess.Interface.Infraestructura
{
    public interface IRepositorioMedicionesSuelo
    {
        Task<List<DtoMedicionesSuelo>> ObtenerDatosMedicionesSuelo();
        Task<DtoRespuestaSP> InsertarMedicionesSuelo(EntityMedicionesSuelo entityMedicionesSuelo);
        Task<DtoRespuestaSP> ModificarMedicionesSuelo(EntityMedicionesSuelo entityMedicionesSuelo);
        Task<DtoRespuestaSP> CambiarEstadoMedicionesSuelo(EntityMedicionesSuelo entityMedicionesSuelo);
    }
}
