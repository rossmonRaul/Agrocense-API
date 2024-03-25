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
        Task<List<DtoProductividadCultivo>> ObtenerProductividadCultivo();
        Task<DtoRespuestaSP> CrearProductividadCultivo(EntityProductividadCultivo entityProductividadCultivo);
        Task<DtoRespuestaSP> ActualizarProductividadCultivo(EntityProductividadCultivo entityProductividadCultivo);
        Task<DtoRespuestaSP> CambiarEstadoProductividadCultivo(EntityProductividadCultivo entityProductividadCultivoo);
        Task<List<DtoCalidadCultivo>> ObtenerCalidadCultivo();
        Task<List<DtoRotacionCultivos>> ObtenerRotacionCultivoSegunEstacionalidad();
        Task<DtoRespuestaSP> CrearCalidadCultivo(EntityCalidadCultivo entityCalidadCultivo);
        Task<DtoRespuestaSP> InsertarRotacionCultivoSegunEstacionalidad(EntityRotacionCultivos entityRotacionCultivos);
        Task<DtoRespuestaSP> ActualizarCalidadCultivo(EntityCalidadCultivo entityCalidadCultivo);
        Task<DtoRespuestaSP> ModificarRotacionCultivoSegunEstacionalidad(EntityRotacionCultivos entityRotacionCultivos);
        Task<DtoRespuestaSP> CambiarEstadoCalidadCultivo(EntityCalidadCultivo entityCalidadCultivo);
        Task<DtoRespuestaSP> CambiarEstadoRotacionCultivo(EntityRotacionCultivos entityRotacionCultivos);
    }
}
