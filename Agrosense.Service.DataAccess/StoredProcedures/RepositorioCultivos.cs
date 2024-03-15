using Agrosense.Service.DataAccess.Interface.Infraestructura;
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



    }
}
