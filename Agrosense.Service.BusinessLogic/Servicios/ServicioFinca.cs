using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Finca;
using Agrosense.Service.DataAccess.Interface.Infraestructura;
using Agrosense.Service.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosense.Service.BusinessLogic.Servicios
{
    public class ServicioFinca:IServicioFinca
    {
        private readonly IRepositorioFinca repositorioFinca;

        public ServicioFinca(IRepositorioFinca repositorioFinca)
        {
            this.repositorioFinca = repositorioFinca;
        }

        public async Task<List<DtoFinca>> ObtenerFincas()
        {
            return await this.repositorioFinca.ObtenerFincas();
        }
    }
}
