using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Parcela;
using Agrosense.Service.DataAccess.Interface.Infraestructura;
using Agrosense.Service.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.BusinessLogic.Servicios
{
    public class ServicioParcela:IServicioParcela
    {
        private readonly IRepositorioParcela repositorioParcela;

        public ServicioParcela(IRepositorioParcela repositorioParcela)
        {
            this.repositorioParcela = repositorioParcela;
        }

        public async Task<List<DtoParcela>> ObtenerParcelas()
        {
            return await this.repositorioParcela.ObtenerParcelas();
        }
    }
}
