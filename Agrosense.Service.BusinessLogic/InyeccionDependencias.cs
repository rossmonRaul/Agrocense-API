﻿
//using Dominio.Interfaces.Aplicacion.EtapaTallerCo;

using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Usuario;
using Agrosense.Service.BusinessLogic.Servicios;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//using Dominio.Interfaces.
using System;
using System.Collections.Generic;
using System.Text;


namespace Agrosense.Service.BusinessLogic
{
    public static class InyeccionDependencias
    {
        public static IServiceCollection AddAplicacion(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddScoped<IServicioEtapaTallerCo, ServicioEtapasTallerCo>();
            services.AddScoped<IServicioUsuario, ServicioUsuario>();
            return services;
        }
    }
}

