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
    public class RepositorioUsoAgua : IRepositorioUsoAgua
    {
        private readonly IContextoBD contextoBD;   

        public RepositorioUsoAgua(IContextoBD contextoBD)
        {
            this.contextoBD = contextoBD;
        }

        public async Task<List<DtoUsoAgua>> ObtenerRegistrosSeguimientoUsoAgua()
        {
            try
            {

                string query = "SPObtenerRegistrosSeguimientoUsoAgua";
                var result = await this.contextoBD.ObtenerListaDeDatos<DtoUsoAgua>(query);

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DtoRespuestaSP> CrearRegistroSeguimientoUsoAgua(EntityUsoAgua entityUsoAgua)
        {
            try
            {


                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@IdFinca", entityUsoAgua.IdFinca);
                data.Add("@IdParcela", entityUsoAgua.IdParcela);
                data.Add("@Fecha", entityUsoAgua.Fecha);
                data.Add("@Actividad", entityUsoAgua.Actividad);
                data.Add("@Caudal", entityUsoAgua.Caudal);
                data.Add("@ConsumoAgua", entityUsoAgua.@ConsumoAgua);
                data.Add("@Observaciones", entityUsoAgua.@Observaciones);
                data.Add("@UsuarioCreacion", entityUsoAgua.@UsuarioCreacion);

                string query = "SPInsertarRegistroSeguimientoUsoAgua";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DtoRespuestaSP> ActualizarRegistroSeguimientoUsoAgua(EntityUsoAgua entityUsoAgua)
        {
            try
            {


                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@IdRegistroSeguimientoUsoAgua", entityUsoAgua.IdRegistroSeguimientoUsoAgua);
                data.Add("@IdFinca", entityUsoAgua.IdFinca);
                data.Add("@IdParcela", entityUsoAgua.IdParcela);
                data.Add("@Fecha", entityUsoAgua.Fecha);
                data.Add("@Actividad", entityUsoAgua.Actividad);
                data.Add("@Caudal", entityUsoAgua.Caudal);
                data.Add("@ConsumoAgua", entityUsoAgua.@ConsumoAgua);
                data.Add("@Observaciones", entityUsoAgua.@Observaciones);
                data.Add("@UsuarioModificacion", entityUsoAgua.@UsuarioModificacion);

                string query = "SPModificarRegistroSeguimientoUsoAgua";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DtoRespuestaSP> CambiarEstadoRegistroSeguimientoUsoAgua(EntityUsoAgua entityUsoAgua)
        {
            try
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@IdRegistroSeguimientoUsoAgua", entityUsoAgua.IdRegistroSeguimientoUsoAgua);
                string query = "SPCambiarEstadoRegistroSeguimientoUsoAgua";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
