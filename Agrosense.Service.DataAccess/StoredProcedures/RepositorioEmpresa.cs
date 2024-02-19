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
    public class RepositorioEmpresa:IRepositorioEmpresa
    {
        private readonly IContextoBD contextoBD;

        public RepositorioEmpresa(IContextoBD contextoBD)
        {
            this.contextoBD = contextoBD;
        }

        public async Task<List<DtoEmpresa>> ObtenerEmpresas()
        {
            try
            {
                
                string query = "ObtenerEmpresas";
                var result = await this.contextoBD.ObtenerListaDeDatos<DtoEmpresa>(query);
                
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<DtoRespuestaSP> InsertarEmpresa(EntityEmpresa entityEmpresa)
        {
            try
            {


                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@IdEmpresa", entityEmpresa.IdEmpresa);
                string query = "";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<DtoRespuestaSP> ActualizarEmpresa(EntityEmpresa entityEmpresa)
        {
            try
            {


                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("@IdEmpresa", entityEmpresa.IdEmpresa);
                string query = "";

                return await this.contextoBD.EjecutarSP(query, data);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
