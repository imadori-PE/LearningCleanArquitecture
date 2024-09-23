using Microsoft.AspNetCore.Mvc;
using PrintLabelsPacking.Application.Services;
using PrintLabelsPacking.Contracts.Labels;

namespace PrintLabelsPacking.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrintedLabelsController : ControllerBase
    {
        private readonly IPrintedLabelService _praintedLabelService;

        public PrintedLabelsController(IPrintedLabelService praintedLabelService)
        {
            _praintedLabelService = praintedLabelService;
        }

        [HttpPost]
        public IActionResult CreatedPrintedLabels(CreatePrintedLabelsRequest request)
        {
            var createdPrintedLabelId= _praintedLabelService.CreatedPrintedLabels(
                request.CodeSectorVariety, request.CodeLabel, request.TypeProduct.ToString(), request.CodePallet, request.NumberBoxes, request.UserId);

            var response = new CreatePrintedLabelsResponse(createdPrintedLabelId, request.TypeProduct);
            return Ok(response); // creates an OKObject that produces an status code 200 Ok
        }
    }
}

/*
 
En C#, cuando trabajas con ASP.NET Core para construir API REST, las anotaciones [ApiController] y [Route("[controller]")] se utilizan 
para configurar controladores que manejan solicitudes HTTP y definen cómo esas solicitudes son enrutadas hacia el controlador correspondiente.

1. [ApiController]:
El atributo [ApiController] se aplica a las clases de controladores en ASP.NET Core para indicar que esa clase está diseñada específicamente 
para manejar solicitudes HTTP de una API (en lugar de, por ejemplo, una aplicación web con vistas).

Al agregar este atributo, habilitas varias funcionalidades útiles de ASP.NET Core, como:

Validación automática del modelo: ASP.NET Core validará automáticamente los parámetros de entrada (del cuerpo, ruta o query) antes de que se 
                                 ejecute el controlador. Si la validación falla, devolverá una respuesta de error 400 Bad Request sin que tengas 
                                 que escribir código adicional.
Enlaces de parámetros simplificados: ASP.NET Core hace coincidir los parámetros de los métodos del controlador con datos de la solicitud (como 
                                    query string, cuerpo JSON, encabezados, etc.) de forma automática.
Respuestas de error automáticas: Cuando no se encuentran los datos o los parámetros son inválidos, se generan respuestas de error automáticas y amigables.

2. [Route("[controller]")]:
El atributo [Route] define el patrón de enrutamiento que ASP.NET Core utilizará para dirigir las solicitudes HTTP hacia las acciones del controlador.

[controller] es un token que ASP.NET Core reemplaza automáticamente por el nombre del controlador. Si tu controlador se llama ProductosController, 
el token [controller] será reemplazado por "productos". Esto te ayuda a evitar errores si cambias el nombre del controlador, ya que no tienes que 
actualizar manualmente la ruta.

Combinación con rutas de acciones ([HttpGet], [HttpPost], etc.):
Puedes combinar [Route("[controller]")] con las rutas de métodos HTTP específicos como [HttpGet], [HttpPost], [HttpPut], etc., 
para definir rutas más detalladas para cada acción.
*/