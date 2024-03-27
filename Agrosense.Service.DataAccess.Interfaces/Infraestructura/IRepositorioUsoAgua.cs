using Agrosense.Service.Model.Dto;
using Agrosense.Service.Model.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Agrosense.Service.DataAccess.Interface.Infraestructura
{
    public interface IRepositorioUsoAgua
    { 
        Task<List<DtoUsoAgua>> ObtenerRegistrosSeguimientoUsoAgua(); 
        Task<DtoRespuestaSP> CrearRegistroSeguimientoUsoAgua(EntityUsoAgua registro);
        Task<DtoRespuestaSP> ActualizarRegistroSeguimientoUsoAgua(EntityUsoAgua registro);
        Task<DtoRespuestaSP> CambiarEstadoRegistroSeguimientoUsoAgua(EntityUsoAgua registro);
        Task<List<DtoUsoAgua>> ObtenerEficienciaRiego();
        Task<DtoRespuestaSP> CrearRegistroEficienciaRiego(EntityEficienciaRiego entityEficienciaRiego);
        Task<DtoRespuestaSP> ActualizarRegistroEficienciaRiego(EntityEficienciaRiego entityEficienciaRiego);
        Task<DtoRespuestaSP> CambiarEstadoRegistroEficienciaRiego(EntityEficienciaRiego entityEficienciaRiego);
        Task<List<DtoUsoAgua>> ObtenerConductividadElectricaEstresHidrico();
        Task<DtoRespuestaSP> CrearRegistroConductividadElectricaEstresHidrico(EntityConductividadElectricaEstresHidrico entityConductividadElectricaEstresHidrico);
        Task<DtoRespuestaSP> ActualizarRegistroConductividadElectricaEstresHidrico(EntityConductividadElectricaEstresHidrico entityConductividadElectricaEstresHidrico);
        Task<DtoRespuestaSP> CambiarEstadoRegistroConductividadElectricaEstresHidrico(EntityConductividadElectricaEstresHidrico entityConductividadElectricaEstresHidrico);
    }
}