using Agrosense.Service.DataAccess.Interface.Infraestructura;
using Agrosense.Service.Model.Dto;
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
    }
}
