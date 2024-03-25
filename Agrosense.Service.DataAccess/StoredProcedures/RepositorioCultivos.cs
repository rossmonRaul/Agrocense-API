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

        public async Task<List<DtoProductividadCultivo>> ObtenerProductividadCultivo()
        {
            try
            {

                string query = "SPObtenerProductividadCultivo";
                var result = await this.contextoBD.ObtenerListaDeDatos<DtoProductividadCultivo>(query);

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<DtoRespuestaSP> CrearProductividadCultivo(EntityProductividadCultivo entityProductividadCultivo)
        {
            try
            {


                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@UsuarioCreacion", entityProductividadCultivo.Usuario);
                data.Add("@IdFinca", entityProductividadCultivo.IdFinca);
                data.Add("@IdParcela", entityProductividadCultivo.IdParcela);
                data.Add("@Cultivo", entityProductividadCultivo.Cultivo);
                data.Add("@Temporada", entityProductividadCultivo.Temporada);
                data.Add("@Area", entityProductividadCultivo.Area);
                data.Add("@Produccion", entityProductividadCultivo.Produccion);
                data.Add("@Productividad", entityProductividadCultivo.Productividad);


                string query = "SPCrearProductividadCultivo";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<DtoRespuestaSP> ActualizarProductividadCultivo(EntityProductividadCultivo entityProductividadCultivo)
        {
            try
            {


                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@UsuarioModificacion", entityProductividadCultivo.Usuario);
                data.Add("@IdManejoProductividadCultivo", entityProductividadCultivo.IdManejoProductividadCultivo);
                data.Add("@IdFinca", entityProductividadCultivo.IdFinca);
                data.Add("@IdParcela", entityProductividadCultivo.IdParcela);
                data.Add("@Cultivo", entityProductividadCultivo.Cultivo);
                data.Add("@Temporada", entityProductividadCultivo.Temporada);
                data.Add("@Area", entityProductividadCultivo.Area);
                data.Add("@Produccion", entityProductividadCultivo.Produccion);
                data.Add("@Productividad", entityProductividadCultivo.Productividad);

                string query = "SPActualizarProductividadCultivo";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DtoRespuestaSP> CambiarEstadoProductividadCultivo(EntityProductividadCultivo entityProductividadCultivo)
        {
            try
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@IdManejoProductividadCultivo", entityProductividadCultivo.IdManejoProductividadCultivo);
                string query = "SPCambiarEstadoProductividadCultivo";

                return await this.contextoBD.EjecutarSP(query, data);
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
