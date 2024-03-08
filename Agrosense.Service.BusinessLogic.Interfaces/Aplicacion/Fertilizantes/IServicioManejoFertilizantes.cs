using Agrosense.Service.Model.Dto;
using Agrosense.Service.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.BusinessLogic.Interface.Aplicacion.Fertilizantes
{
    public interface IServicioManejoFertilizantes
    {
        Task<List<DtoManejoFertilizantes>> ObtenerManejoFertilizantes();
        Task<DtoRespuestaSP> InsertarManejoFertilizantes(EntityManejoFertilizantes entityManejoFertilizanteso);
        Task<DtoRespuestaSP> ActualizarManejoFertilizantes(EntityManejoFertilizantes entityManejoFertilizantes);
    }
}
