using Agrosense.Service.Model.Dto;
using Agrosense.Service.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.DataAccess.Interface.Infraestructura
{
    public interface IRepositorioCultivos
    {
        Task<List<DtoCalidadCultivo>> ObtenerCalidadCultivo();
        Task<DtoRespuestaSP> CrearCalidadCultivo(EntityCalidadCultivo entityCalidadCultivo);
        Task<DtoRespuestaSP> ActualizarCalidadCultivo(EntityCalidadCultivo entityCalidadCultivo);
        Task<DtoRespuestaSP> CambiarEstadoCalidadCultivo(EntityCalidadCultivo entityCalidadCultivo);
    }
}
