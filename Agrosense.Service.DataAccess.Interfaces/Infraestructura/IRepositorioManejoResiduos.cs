using Agrosense.Service.Model.Dto;
using Agrosense.Service.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.DataAccess.Interface.Infraestructura
{
    public interface IRepositorioManejoResiduos
    {
        Task<List<DtoManejoResiduos>> ObtenerManejoResiduos();
        Task<DtoRespuestaSP> InsertarManejoResiduos(EntityManejoResiduos entityManejoResiduos);
        Task<DtoRespuestaSP> ActualizarManejoResiduos(EntityManejoResiduos entityManejoResiduos);
        Task<DtoRespuestaSP> CambiarEstadoManejoResiduos(EntityManejoResiduos entityManejoResiduos);
    }
}
