using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Cultivos;
using Agrosense.Service.DataAccess.Interface.Infraestructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.BusinessLogic.Servicios
{
    public class ServicioCutivos: IServicioCultivos
    {
        private readonly IRepositorioCultivos repositorioCultivos;

        public ServicioCutivos(IRepositorioCultivos repositorioCultivos)
        {
            this.repositorioCultivos = repositorioCultivos;
        }

    }
}
