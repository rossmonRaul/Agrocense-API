using Agrosense.Service.DataAccess.Interface.Infraestructura;
using Agrosense.Service.Model.Dto;
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

                string query = "ObtenerFincas";
                var result = await this.contextoBD.ObtenerListaDeDatos<DtoFinca>(query);

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
