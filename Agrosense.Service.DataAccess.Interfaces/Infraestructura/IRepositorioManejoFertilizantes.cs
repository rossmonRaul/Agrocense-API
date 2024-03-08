using Agrosense.Service.Model.Dto;
using Agrosense.Service.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.DataAccess.Interface.Infraestructura
{
    public interface IRepositorioManejoFertilizantes
    {
        Task<List<DtoManejoFertilizantes>> ObtenerManejoFertilizantes();
        Task<DtoRespuestaSP> InsertarManejoFertilizantes(EntityManejoFertilizantes entityManejoFertilizantes);
        Task<DtoRespuestaSP> ActualizarManejoFertilizantes(EntityManejoFertilizantes entityManejoFertilizantes);
        Task<DtoRespuestaSP> CambiarEstadoManejoFertilizantes(EntityManejoFertilizantes entityManejoFertilizantes);
    }
}
