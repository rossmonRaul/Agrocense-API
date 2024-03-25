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
    public class RepositorioCultivos:IRepositorioCultivos
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
                data.Add("@Productividad", entityProductividadCultivo.Produccion);


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
                data.Add("@Productividad", entityProductividadCultivo.Produccion);

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

    }
}
