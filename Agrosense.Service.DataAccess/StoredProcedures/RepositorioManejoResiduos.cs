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
    public class RepositorioManejoResiduos : IRepositorioManejoResiduos
    {
        private readonly IContextoBD contextoBD;

        public RepositorioManejoResiduos(IContextoBD contextoBD)
        {
            this.contextoBD = contextoBD;
        }

        //Obtener los registro de Manejo de Fertilizantes
        public async Task<List<DtoManejoResiduos>> ObtenerManejoResiduos()
        {
            try
            {
                string query = "SPObtenerManejoResiduos";
                var result = await this.contextoBD.ObtenerListaDeDatos<DtoManejoResiduos>(query);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DtoRespuestaSP> InsertarManejoResiduos(EntityManejoResiduos entityManejoResiduos)
        {
            try
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@IdFinca", entityManejoResiduos.IdFinca);
                data.Add("@IdParcela", entityManejoResiduos.IdParcela);
                data.Add("@Residuo", entityManejoResiduos.Residuo);
                data.Add("@FechaGeneracion", entityManejoResiduos.FechaGeneracion);
                data.Add("@FechaManejo", entityManejoResiduos.FechaManejo);
                data.Add("@Cantidad", entityManejoResiduos.Cantidad);
                data.Add("@AccionManejo", entityManejoResiduos.AccionManejo);
                data.Add("@DestinoFinal", entityManejoResiduos.DestinoFinal);
                data.Add("@UsuarioCreacion", entityManejoResiduos.UsuarioCreacion);
                data.Add("@IdentificacionUsuario", entityManejoResiduos.IdentificacionUsuario);
                string query = "SPInsertarManejoResiduos";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DtoRespuestaSP> ActualizarManejoResiduos(EntityManejoResiduos entityManejoResiduos)
        {
            try
            {

                Dictionary<string, object> data = new Dictionary<string, object>();

                data.Add("@IdManejoResiduos", entityManejoResiduos.IdManejoResiduos);
                data.Add("@IdFinca", entityManejoResiduos.IdFinca);
                data.Add("@IdParcela", entityManejoResiduos.IdParcela);
                data.Add("@Residuo", entityManejoResiduos.Residuo);
                data.Add("@FechaGeneracion", entityManejoResiduos.FechaGeneracion);
                data.Add("@FechaManejo", entityManejoResiduos.FechaManejo);
                data.Add("@Cantidad", entityManejoResiduos.Cantidad);
                data.Add("@AccionManejo", entityManejoResiduos.AccionManejo);
                data.Add("@DestinoFinal", entityManejoResiduos.DestinoFinal);
                data.Add("@UsuarioModificacion", entityManejoResiduos.UsuarioModificacion);

                string query = "SPModificarManejoResiduos";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DtoRespuestaSP> CambiarEstadoManejoResiduos(EntityManejoResiduos entityManejoResiduos)
        {
            try
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@IdManejoResiduos", entityManejoResiduos.IdManejoResiduos);
                string query = "SPCambiarManejoResiduos";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
