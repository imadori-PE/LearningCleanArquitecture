using PrintLabelsPacking.Application;
using PrintLabelsPacking.Infraestructure;

var builder = WebApplication.CreateBuilder(args); //utiliza el patr�n de inyecci�n de dependencias 
{
    // Add services to the container.
    builder.Services.AddControllers();
    /*
     * Este m�todo agrega los servicios necesarios para que la aplicaci�n pueda utilizar controladores MVC que manejan solicitudes HTTP 
     * y devuelven respuestas JSON (espec�ficamente para API REST).
     * A�adir AddControllers() asegura que ASP.NET Core reconozca los controladores y permita que gestionen rutas, acciones y respuestas HTTP.
    */
    builder.Services.AddEndpointsApiExplorer();
    /*
     * Este m�todo habilita una caracter�stica llamada API Explorer que genera documentaci�n autom�tica de los puntos finales de la API (endpoints).
     * Es �til, por ejemplo, cuando se utiliza con herramientas como Swagger para generar documentaci�n interactiva de la API.
     * Sin AddEndpointsApiExplorer(), la aplicaci�n no generar�a autom�ticamente la lista de endpoints disponibles para la documentaci�n.
     */

    //builder.Services.AddScoped<IPrintedLabelService, PrintedLabelService>();
    // es una soluci�n pero no es tan eficiente a largo plazo 
    builder.Services.AddAplication()
                    .AddInfraestructure();
    /*
     * Este es un ejemplo de inyecci�n de dependencias. El servicio IPrintedLabelService es una interfaz, y PrintedLabelService es su implementaci�n. 
     * Con esta l�nea de c�digo, indicas que:
     * Siempre que el sistema necesite una instancia de IPrintedLabelService durante una solicitud HTTP, se le dar� una instancia de PrintedLabelService.
     * AddScoped especifica que la instancia se crea una vez por cada solicitud HTTP y se comparte durante la misma solicitud. 
     * Es decir, si tienes m�ltiples controladores o servicios que dependen de IPrintedLabelService durante una �nica solicitud HTTP, 
     * todos recibir�n la misma instancia.
     */
}

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
