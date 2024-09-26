using PrintLabelsPacking.Application;
using PrintLabelsPacking.Infraestructure;

var builder = WebApplication.CreateBuilder(args); //utiliza el patrón de inyección de dependencias 
{
    // Add services to the container.
    builder.Services.AddControllers();
    /*
     * Este método agrega los servicios necesarios para que la aplicación pueda utilizar controladores MVC que manejan solicitudes HTTP 
     * y devuelven respuestas JSON (específicamente para API REST).
     * Añadir AddControllers() asegura que ASP.NET Core reconozca los controladores y permita que gestionen rutas, acciones y respuestas HTTP.
    */
    builder.Services.AddEndpointsApiExplorer();
    /*
     * Este método habilita una característica llamada API Explorer que genera documentación automática de los puntos finales de la API (endpoints).
     * Es útil, por ejemplo, cuando se utiliza con herramientas como Swagger para generar documentación interactiva de la API.
     * Sin AddEndpointsApiExplorer(), la aplicación no generaría automáticamente la lista de endpoints disponibles para la documentación.
     */

    //builder.Services.AddScoped<IPrintedLabelService, PrintedLabelService>();
    // es una solución pero no es tan eficiente a largo plazo 
    builder.Services.AddAplication()
                    .AddInfraestructure();
    /*
     * Este es un ejemplo de inyección de dependencias. El servicio IPrintedLabelService es una interfaz, y PrintedLabelService es su implementación. 
     * Con esta línea de código, indicas que:
     * Siempre que el sistema necesite una instancia de IPrintedLabelService durante una solicitud HTTP, se le dará una instancia de PrintedLabelService.
     * AddScoped especifica que la instancia se crea una vez por cada solicitud HTTP y se comparte durante la misma solicitud. 
     * Es decir, si tienes múltiples controladores o servicios que dependen de IPrintedLabelService durante una única solicitud HTTP, 
     * todos recibirán la misma instancia.
     */
}

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
