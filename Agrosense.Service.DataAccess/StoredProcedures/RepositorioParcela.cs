using Agrosense.Service.DataAccess.Interface.Infraestructura;
using Agrosense.Service.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.DataAccess.StoredProcedures
{
    public class RepositorioParcela:IRepositorioParcela
    {
        private readonly IContextoBD contextoBD;

        public RepositorioParcela(IContextoBD contextoBD)
        {
            this.contextoBD = contextoBD;
        }

        public async Task<List<DtoParcela>> ObtenerParcelas()
        {
            try
            {

                string query = "ObtenerParcelas";
                var result = await this.contextoBD.ObtenerListaDeDatos<DtoParcela>(query);

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
