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
    public class RepositorioPreparacionTerreno : IRepositorioPreparacionTerreno
    {
        private readonly IContextoBD contextoBD;

        public RepositorioPreparacionTerreno(IContextoBD contextoBD)
        {
            this.contextoBD = contextoBD;
        }

        //Obtener los registro de preparacion de terreno
        public async Task<List<DtoPreparacionTerreno>> ObtenerDatosPreparacionTerreno()
        {
            try
            {
                string query = "SPObtenerPreparacionTerreno";
                var result = await this.contextoBD.ObtenerListaDeDatos<DtoPreparacionTerreno>(query);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DtoRespuestaSP> InsertarPreparacionTerreno(EntityPreparacionTerreno entityPreparacionTerreno)
        {
            try
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@IdFinca", entityPreparacionTerreno.IdFinca);
                data.Add("@IdParcela", entityPreparacionTerreno.IdParcela);
                data.Add("@Fecha", entityPreparacionTerreno.Fecha);
                data.Add("@Actividad", entityPreparacionTerreno.Actividad);
                data.Add("@Maquinaria", entityPreparacionTerreno.Maquinaria);
                data.Add("@Observaciones", entityPreparacionTerreno.Observaciones);
                data.Add("@UsuarioCreacionModificacion", entityPreparacionTerreno.UsuarioCreacionModificacion);
                string query = "SPInsertarPreparacionTerreno";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DtoRespuestaSP> ModificarPreparacionTerreno(EntityPreparacionTerreno entityPreparacionTerreno)
        {
            try
            {

                Dictionary<string, object> data = new Dictionary<string, object>();

                data.Add("@IdPreparacionTerreno", entityPreparacionTerreno.IdPreparacionTerreno);
                data.Add("@IdFinca", entityPreparacionTerreno.IdFinca);
                data.Add("@IdParcela", entityPreparacionTerreno.IdParcela);
                data.Add("@Fecha", entityPreparacionTerreno.Fecha);
                data.Add("@Actividad", entityPreparacionTerreno.Actividad);
                data.Add("@Maquinaria", entityPreparacionTerreno.Maquinaria);
                data.Add("@Observaciones", entityPreparacionTerreno.Observaciones);
                data.Add("@UsuarioCreacionModificacion", entityPreparacionTerreno.UsuarioCreacionModificacion);

                string query = "SPModificarPreparacionTerreno";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DtoRespuestaSP> CambiarEstadoPreparacionTerreno(EntityPreparacionTerreno entityPreparacionTerreno)
        {
            try
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@IdPreparacionTerreno", entityPreparacionTerreno.IdPreparacionTerreno);
                string query = "SPCambiarEstadoPreparacionTerreno";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
