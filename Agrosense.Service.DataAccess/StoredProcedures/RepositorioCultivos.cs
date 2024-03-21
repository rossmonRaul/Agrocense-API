using Agrosense.Service.DataAccess.Interface.Infraestructura;
using Agrosense.Service.Model.Dto;
using Agrosense.Service.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.DataAccess.StoredProcedures
{
    public class RepositorioCultivos : IRepositorioCultivos
    {
        private readonly IContextoBD contextoBD;

        public RepositorioCultivos(IContextoBD contextoBD)
        {
            this.contextoBD = contextoBD;
        }

        public async Task<List<DtoCalidadCultivo>> ObtenerCalidadCultivo()
        {
            try
            {

                string query = "SPObtenerCalidadCultivo";
                var result = await this.contextoBD.ObtenerListaDeDatos<DtoCalidadCultivo>(query);

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<DtoRotacionCultivos>> ObtenerRotacionCultivoSegunEstacionalidad()
        {
            try
            {

                string query = "SPObtenerRotacionCultivoSegunEstacionalidad";
                var result = await this.contextoBD.ObtenerListaDeDatos<DtoRotacionCultivos>(query);

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DtoRespuestaSP> CrearCalidadCultivo(EntityCalidadCultivo entityCalidadCultivo)
        {
            try
            {


                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@UsuarioCreacion", entityCalidadCultivo.UsuarioCreacionModificacion);
                data.Add("@IdFinca", entityCalidadCultivo.IdFinca);
                data.Add("@IdParcela", entityCalidadCultivo.IdParcela);
                data.Add("@FechaCreacion", entityCalidadCultivo.FechaCreacion);
                data.Add("@Cultivo", entityCalidadCultivo.Cultivo);
                data.Add("@Hora", entityCalidadCultivo.Hora);
                data.Add("@Lote", entityCalidadCultivo.Lote);
                data.Add("@PesoTotal", entityCalidadCultivo.PesoTotal);
                data.Add("@PesoPromedio", entityCalidadCultivo.PesoPromedio);
                data.Add("@Calidad", entityCalidadCultivo.Calidad);
                data.Add("@Observaciones", entityCalidadCultivo.Observaciones);

                string query = "SPCrearCalidadCultivo";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<DtoRespuestaSP> InsertarRotacionCultivoSegunEstacionalidad(EntityRotacionCultivos entityRotacionCultivos)
        {
            try
            {


                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@IdFinca", entityRotacionCultivos.IdFinca);
                data.Add("@IdParcela", entityRotacionCultivos.IdParcela);
                data.Add("@IdentificacionUsuario", entityRotacionCultivos.IdentificacionUsuario);
                data.Add("@Cultivo", entityRotacionCultivos.Cultivo);
                data.Add("@EpocaSiembra", entityRotacionCultivos.EpocaSiembra);
                data.Add("@TiempoCosecha", entityRotacionCultivos.TiempoCosecha);
                data.Add("@CultivoSiguiente", entityRotacionCultivos.CultivoSiguiente);
                data.Add("@EpocaSiembraCultivoSiguiente", entityRotacionCultivos.EpocaSiembraCultivoSiguiente);
                string query = "SPInsertarRotacionCultivoSegunEstacionalidad";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<DtoRespuestaSP> ActualizarCalidadCultivo(EntityCalidadCultivo entityCalidadCultivo)
        {
            try
            {


                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@UsuarioModificacion", entityCalidadCultivo.UsuarioCreacionModificacion);
                data.Add("@IdManejoCalidadCultivo", entityCalidadCultivo.IdManejoCalidadCultivo);
                data.Add("@IdFinca", entityCalidadCultivo.IdFinca);
                data.Add("@IdParcela", entityCalidadCultivo.IdParcela);
                data.Add("@FechaCreacion", entityCalidadCultivo.FechaCreacion);
                data.Add("@Cultivo", entityCalidadCultivo.Cultivo);
                data.Add("@Hora", entityCalidadCultivo.Hora);
                data.Add("@Lote", entityCalidadCultivo.Lote);
                data.Add("@PesoTotal", entityCalidadCultivo.PesoTotal);
                data.Add("@PesoPromedio", entityCalidadCultivo.PesoPromedio);
                data.Add("@Calidad", entityCalidadCultivo.Calidad);
                data.Add("@Observaciones", entityCalidadCultivo.Observaciones);

                string query = "SPActualizarCalidadCultivo";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<DtoRespuestaSP> ModificarRotacionCultivoSegunEstacionalidad(EntityRotacionCultivos entityRotacionCultivos)
        {
            try
            {


                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@IdRotacionCultivoSegunEstacionalidad", entityRotacionCultivos.IdRotacionCultivoSegunEstacionalidad);
                data.Add("@IdFinca", entityRotacionCultivos.IdFinca);
                data.Add("@IdParcela", entityRotacionCultivos.IdParcela);
                data.Add("@IdentificacionUsuario", entityRotacionCultivos.IdentificacionUsuario);
                data.Add("@Cultivo", entityRotacionCultivos.Cultivo);
                data.Add("@EpocaSiembra", entityRotacionCultivos.EpocaSiembra);
                data.Add("@TiempoCosecha", entityRotacionCultivos.TiempoCosecha);
                data.Add("@CultivoSiguiente", entityRotacionCultivos.CultivoSiguiente);
                data.Add("@EpocaSiembraCultivoSiguiente", entityRotacionCultivos.EpocaSiembraCultivoSiguiente);

                string query = "SPModificarRotacionCultivoSegunEstacionalidad";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DtoRespuestaSP> CambiarEstadoCalidadCultivo(EntityCalidadCultivo entityCalidadCultivo)
        {
            try
            {


                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@IdManejoCalidadCultivo", entityCalidadCultivo.IdManejoCalidadCultivo);
                string query = "SPCambiarEstadoCalidadCultivo";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<DtoRespuestaSP> CambiarEstadoRotacionCultivo(EntityRotacionCultivos entityRotacionCultivos)
        {
            try
            {


                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@IdRotacionCultivoSegunEstacionalidad", entityRotacionCultivos.IdRotacionCultivoSegunEstacionalidad);
                string query = "SPCambiarEstadoRotacionCultivo";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
