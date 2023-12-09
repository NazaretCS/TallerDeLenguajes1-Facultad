/*

    Web API con ASP Net Core
    ************************
        Las siglas ASP significan Active Server Pages. ASP es una tecnología de programación desarrollada por Microsoft como parte de la plataforma ASP.NET. Se utiliza para crear aplicaciones web dinámicas y sitios web interactivos.
        ASP permite la ejecución de código del lado del servidor para generar contenido web personalizado antes de ser enviado al navegador del usuario.

        Al día de hoy con ASP.NET Core contamos con dos posibilidades para crear WEB APIs
        • WebAPI basadas en controladores (heredan de ControllerBase)
        • WebAPI sin controladores (mínimal API )


        WebAPI basadas en controladores (heredan de ControllerBase)
        *******************************
        Proponen un enfoque más extenso y robusto para crear APIs HTTP con ASP.NET Core. Permite construir end-points REST completamente funcionales utiliza el scaffolding tradicional de ASP.Net Core y el aportan el uso controlador para la separación lógica de responsabilidades y funcionalidades.


        WebAPI sin controladores (minimal API )
        ************************
        Proponen un enfoque simplificado para crear rápidamente APIs HTTP con ASP.NET Core. Puedes construir end-points REST completamente funcionales con un código y configuración mínimos. Evita el scaffolding tradicional y los controladores innecesarios al declarar de manera fluida las rutas y acciones de la API.


        Crear una nuevo proyecto webAPI
        ******************************
             dotnet new webapi -n MiWebAPI  -> Crea un nuevo proyecto API
    
            code -r MiWebAPI   ->   Abre Vs code desde la terminal con el proyecto
        

        MiddleWare
        **********

            Middleware es un concepto esencial en ASP.NET que hace posible la personalización y el procesamiento de solicitudes HTTP de manera modular y organizada en las aplicaciones web.


            Funcionamiento
            • Los middlewares se organizan en una cadena o "pipeline" de procesamiento. Cuando una solicitud HTTP entra en la aplicación, pasa secuencialmente a través de esta cadena de middlewares. 
            • Cada middleware en la cadena tiene la oportunidad de procesar la solicitud, tomar decisiones y modificar la respuesta antes de que pase al siguiente middleware o se envíe una respuesta al cliente.


            Orden y Funcionalidad
            Los middlewares se ejecutan en un orden específico, lo que permite una personalización y procesamiento gradual de las solicitudes. Cada middleware realiza una tarea específica.
            Algunos ejemplos comunes incluyen:
            • Autenticación
            • Autorización
            • Enrutamiento
            • Registro compresión y manipulación de encabezados HTTP.

        
        Controladores
        *************

            Que es un controlador en ASP
            ****************************

                En ASP.NET Web API, un controlador es una clase que controla las solicitudes HTTP. Los métodos públicos del controlador se denominan métodos de acción o simplemente acciones. Cuando el marco de api web recibe una solicitud, enruta la solicitud a una acción.

                Son Clases qué:
                    ● Se pueden marcan con de atributos [ApiController]
                    ● Heredan de la Clase BaseController o Controller
                    ● Es el punto de entrada para las solicitudes HTTP.
                    ● Emiten las respuestas para las respuestas HTTP


            Clase ControllerBase
            ********************

                Una API web basada en controladores consta de una o más clases de controladores que derivan de ControllerBase.

                ControllerBase  -> Clase de la que debemos derivar para implementar un controlador en web API. El response será un Json

                Controller  ->     Clase de la que debemos derivar para implementar un controlador en páginas WEB. Agrega soportes para manejar vistas.
            

            RUTEO DE RECURSOS
            *****************

                Hay algunas formas de controlar el enrutamiento en una aplicación ASP.NET Core, nos concentraremos en las dos formas más comunes:
                    ->Enrutamiento convencional: La ruta se determina en función de convenciones que se definen en plantillas de ruta que, en tiempo de  ejecución, mapearán las solicitudes a controladores (clases) y acciones (métodos).
                    -> Enrutamiento basado en atributos: La ruta se determina en función de los atributos que establece en sus controladores y métodos. Estos atributos definirán la asignación a las acciones del controlador.
                
            Ruteo
            ******

                Ruteo de recursos – Convencional

                Los controladores de ASP.NET Core utilizan el middleware Routing para hacer coincidir las URL de las solicitudes entrantes y asignarlas a acciones. Plantillas de ruta se definen al inicio en Program.cs o en atributos.

                Forma convencional de rutear un recurso:
                "{controller}/{action}/{id?}"

                ● El primer parámetro del path, {controller}, Mapea el controlador.
                ● El segundo parámetro de path, {action}, mapea el nombre de la acción vinculada.
                ● El tercer parámetro, {id?} es usado como parámetro opcional id. El ? en {id?} hace que sea opcional. id es usado para mapear al model de entidad
            
        Atributos - Attributes
        **********************

            Definición
            **********

                En C#, los atributos son clases que se heredan de la clase base Attribute. Cualquier clase que se hereda de Attribute puede usarse como una especie de "etiqueta" en otros fragmentos de código.      

                Los atributos proporcionan un método eficaz para asociar metadatos, o información declarativa, con código (ensamblados, Clases, tipos, métodos, propiedades, etc.).
                Se los utiliza colocando el nombre de la clase entre corchetes “[Atributo]” y anteponiéndolo a un fragmento de código. 
                Ejemplo de uso:

                [Atributo]
                public class MiNuevaClase{ //elementos de la clase… }

                [Atributo]
                public void Método{ //código de del método… }
            
        
        Crear un nuevo proyecto MVC
        ****************************

            Ruteo de recursos – Atributos
            *****************************

                El Ruteo por atributos reescribe el ruteo convencional y aplica nuevas reglas de ruteo, esto lo hace mediante el uso de atributos, se puede aplicar estas nuevas rutas por medio de el atributo [ApiController] o [Route]. También puede usarse en los diferentes Métodos de acción.
                El atributo [ApiController] debe aplicarse a sus controladores para identificarlos como controladores.
                El atributo [Route] permite definir la ruta de acceso a dicho controlador.
            
                Controlador ejemplo con atributos

                Aquí se puede ver como se declara una clase que hereda de la clase ControllerBase, y que tiene los atributos necesarios para que se la declare

                [ApiController]
                [Route("[controller]")]
                public class PronosticoDelClimaController : ControllerBase
                {
                    […]
                }

                Ruta http para acceder al controlador en cuestión
                https://localhost:5001/PronosticoDelClima


             Atributos para Identificar un verbo HTTP en un Action
            ******************************************************
                Atributo         Verbo

                [HttpGet]        Get
                [HttpPut]        Put
                [HttpPost]       Post
                [HttpDelete]     Delete
                [HttpHead]       Head
                [HttpOptions]    Options
                [HttpPatch]      Patch


            ************************************************************
            *                                                          *
            *   EJEMPLOS DE COMO USAR LOS REQUEST Y ATRIBUTOS EN PPT   *    
            *                                                          *
            ************************************************************



            Request HTTP
            ************

                Atributos para recuperar información de un request

                Cuando se trabaja con APIs, es común recibir datos de diferentes fuentes, como envíos de formularios, cuerpos de solicitud o parámetros de consulta. En ASP.Net Core, puedes utilizar los atributos FromForm, FromBody y FromQuery para vincular fácilmente los datos entrantes a los parámetros del método de acción.

                Atributo Fuente donde se obtienen los datos
                *******************************************

                [FromBody]      Desde el cuerpo del Request
                [FromForm]      Desde los datos en formulario en el cuerpo de un Request
                [FromHeader]    Request desde el header del request
                [FromQuery]     Desde los parámetros del query string
                [FromRoute]     Desde los datos de una ruta en el Request


                Método Post con un objeto en el cuerpo del request
                
                https://localhost:{PORT}/Paciente/Alta

                [ApiController]
                [Route("[controller]")]
                public class PacienteController : ControllerBase
                {
                    [HttpGet(“Alta")]
                    public IActionResult Alta([FromBody] paciente paciente)
                    {
                        //codigo que devuelve el clima
                    }
                }

            
            
            Método Get retornando valores
            *****************************

                Tipo específico: La acción más simple devuelve un tipo de dato primitivo o complejo (por ejemplo, una cadena o un objeto personalizado). Considera la siguiente acción, que devuelve una colección de objetos Product personalizados

                    [HttpGet]
                    public List<Producto> Get()
                    {
                        return new list<Producto>();
                    }

                
                IActionResult y ActionResult<T> : es una interfaz comúnmente utilizada para representar el resultado de una acción en un controlador ASP.NET Core. Esta interfaz permite que una acción devuelva una variedad de tipos de resultados, lo que proporciona flexibilidad al desarrollador para elegir el tipo de respuesta que mejor se adapte a la situación.

                    [HttpGet]
                    public ActionResult<Producto> Get()
                    {
                        return Ok(Product);
                    }

                
                Status code
                Estos son algunos de los códigos de estado HTTP comunes y los métodos de ASP.NET Core que los devuelven

                Código de status                Retorno desde ASP
                200 OK                          return Ok()
                201 Created                     return Created("/api/productos/1", newProduct);
                204 No Content                  return NoContent();
                400 Bad Request                 return BadRequest("Solicitud incorrecta");
                401 Unauthorized                return Unauthorized();
                403 Forbidden                   return Forbid();
                404 Not Found                   return NotFound("Recurso no encontrado");
                500 Internal Server Error       return StatusCode(500, "Error interno del servidor");



                
*/