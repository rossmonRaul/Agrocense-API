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
    public class RepositorioFinca:IRepositorioFinca
    {
        private readonly IContextoBD contextoBD;

        public RepositorioFinca(IContextoBD contextoBD)
        {
            this.contextoBD = contextoBD;
        }

        public async Task<List<DtoFinca>> ObtenerFincas()
        {
            try
            {
                string query = "SPObtenerFincas";
                var result = await this.contextoBD.ObtenerListaDeDatos<DtoFinca>(query);

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DtoRespuestaSP> CrearFinca(EntityFinca entityFinca)
        {
            try
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@Finca", entityFinca.Nombre);
                data.Add("@IdEmpresa", entityFinca.IdEmpresa);
                string query = "SPCrearFinca";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<DtoRespuestaSP> ActualizarFinca(EntityFinca entityFinca)
        {
            try
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@IdFinca", entityFinca.IdFinca);
                data.Add("@NuevoNombreFinca", entityFinca.Nombre);
                string query = "SPActualizarFinca";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<DtoRespuestaSP> CambiarEstadoFinca(EntityFinca entityFinca)
        {
            try
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@IdFinca", entityFinca.IdFinca);
                string query = "SPCambiarEstadoFinca";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
