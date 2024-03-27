using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Cultivos;
using Agrosense.Service.BusinessLogic.Interface.Aplicacion.UsoAgua;
using Agrosense.Service.DataAccess.Interface.Infraestructura;
using Agrosense.Service.Model.Dto;
using Agrosense.Service.Model.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Agrosense.Service.BusinessLogic.Servicios
{
    public class ServicioUsoAgua : IServicioUsoAgua
    {
        private readonly IRepositorioUsoAgua repositorioUsoAgua;

        public ServicioUsoAgua(IRepositorioUsoAgua repositorioRegistroSeguimientoUsoAgua)
        {
            this.repositorioUsoAgua = repositorioRegistroSeguimientoUsoAgua;
        }

        public async Task<List<DtoUsoAgua>> ObtenerRegistrosSeguimientoUsoAgua()
        {
            return await this.repositorioUsoAgua.ObtenerRegistrosSeguimientoUsoAgua();
        }

        public async Task<DtoRespuestaSP> ActualizarRegistroSeguimientoUsoAgua(EntityUsoAgua entityUsoAgua)
        {
            return await this.repositorioUsoAgua.ActualizarRegistroSeguimientoUsoAgua(entityUsoAgua);
        }

        public async Task<DtoRespuestaSP> CambiarEstadoRegistroSeguimientoUsoAgua(EntityUsoAgua entityUsoAgua)
        {
            return await this.repositorioUsoAgua.CambiarEstadoRegistroSeguimientoUsoAgua(entityUsoAgua);
        }

        public async Task<DtoRespuestaSP> CrearRegistroSeguimientoUsoAgua(EntityUsoAgua entityUsoAgua)
        {
            return await this.repositorioUsoAgua.CrearRegistroSeguimientoUsoAgua(entityUsoAgua);
        }

        //Eficiencia Riego
        public async Task<List<DtoEficienciaRiego>> ObtenerEficienciaRiego()
        {
            return await this.repositorioUsoAgua.ObtenerEficienciaRiego();
        }

        public async Task<DtoRespuestaSP> ActualizarRegistroEficienciaRiego(EntityEficienciaRiego entityEficienciaRiego)
        {
            return await this.repositorioUsoAgua.ActualizarRegistroEficienciaRiego(entityEficienciaRiego);
        }

        public async Task<DtoRespuestaSP> CambiarEstadoRegistroEficienciaRiego(EntityEficienciaRiego entityEficienciaRiego)
        {
            return await this.repositorioUsoAgua.CambiarEstadoRegistroEficienciaRiego(entityEficienciaRiego);
        }

        public async Task<DtoRespuestaSP> CrearRegistroEficienciaRiego(EntityEficienciaRiego entityEficienciaRiego)
        {
            return await this.repositorioUsoAgua.CrearRegistroEficienciaRiego(entityEficienciaRiego);
        }

        //Eficiencia  Conductividad Electrica Estres Hidrico

        public async Task<List<DtoConductividadElectricaEstresHidrico>> ObtenerConductividadElectricaEstresHidrico()
        {
            return await this.repositorioUsoAgua.ObtenerConductividadElectricaEstresHidrico();
        }

        public async Task<DtoRespuestaSP> ActualizarRegistroConductividadElectricaEstresHidrico(EntityConductividadElectricaEstresHidrico entityConductividadElectricaEstresHidrico)
        {
            return await this.repositorioUsoAgua.ActualizarRegistroConductividadElectricaEstresHidrico(entityConductividadElectricaEstresHidrico);
        }

        public async Task<DtoRespuestaSP> CambiarEstadoRegistroConductividadElectricaEstresHidrico(EntityConductividadElectricaEstresHidrico entityConductividadElectricaEstresHidrico)
        {
            return await this.repositorioUsoAgua.CambiarEstadoRegistroConductividadElectricaEstresHidrico(entityConductividadElectricaEstresHidrico);
        }

        public async Task<DtoRespuestaSP> CrearRegistroConductividadElectricaEstresHidrico(EntityConductividadElectricaEstresHidrico entityConductividadElectricaEstresHidrico)
        {
            return await this.repositorioUsoAgua.CrearRegistroConductividadElectricaEstresHidrico(entityConductividadElectricaEstresHidrico);
        }
    }
}
