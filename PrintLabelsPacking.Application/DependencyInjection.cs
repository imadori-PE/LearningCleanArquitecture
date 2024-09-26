using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using PrintLabelsPacking.Application.Services;

namespace PrintLabelsPacking.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAplication(this IServiceCollection services)
        {
            services.AddScoped<IPrintedLabelWriteService, PrintedLabelWriteService>();
            return services;
        }
    }
}

/*
 * IServiceCollection AddAplication( this IServiceCollection services)
 * es un método de extensión para la clase IServiceCollection, que se utiliza comúnmente 
 * en ASP.NET Core para registrar servicios en el contenedor de inyección de dependencias (Dependency Injection).
 * 
 * Este patrón de método de extensión permite organizar y encapsular la lógica de configuración de los servicios de manera más clara y modular, 
 * facilitando su reutilización en diferentes proyectos o capas de la aplicación.
 * 
 * IServiceCollection: Es la interfaz que ASP.NET Core usa para registrar servicios en el contenedor de inyección de dependencias. 
 * Aquí estás extendiendo esa funcionalidad para agregar tus propios servicios.
 */

/*
 * Ventajas de usar métodos de extensión como este:
 * Modularidad: Permite dividir la configuración del servicio en métodos separados, lo que facilita el mantenimiento y la reutilización de código.
 * Reutilización: Si tienes múltiples proyectos o diferentes capas de una aplicación (por ejemplo, capa de infraestructura, capa de dominio, etc.), 
 *               puedes reutilizar este método de extensión para agregar servicios comunes en todos ellos.
 * Legibilidad: Hace que el archivo Program.cs o Startup.cs sea más limpio y fácil de leer, ya que las configuraciones específicas de 
 *              los servicios están encapsuladas en métodos de extensión separados.
 * Buenas prácticas:
 * Nombres descriptivos: En lugar de llamar al método AddAplication, puedes darle un nombre más específico relacionado con el contexto, 
 *                       como AddPrintedLabelServices o AddBusinessServices, dependiendo de lo que se esté registrando en el método.
 * Agrupación de servicios: Si tu aplicación tiene muchas dependencias, puedes crear varios métodos de extensión que agrupen diferentes tipos de servicios, 
 *                          por ejemplo, AddInfrastructureServices, AddDomainServices, etc.
 * De esta manera, puedes seguir un enfoque limpio y organizado para registrar servicios en tu aplicación ASP.NET Core.
 */