/** 

    API (Interfaz de programacion de aplicaciones)
    **********************************************

        Es un conjunto de reglas bien definidas que se utilizan para espesificar formalmente la comunicacion entre componentes de un software 

        Existen muchos tipos de apis y formas de categorisarlas, por ejemplo se puede categorisar las apis por el tipo de acceso de las mismas:

            * APIs Privadas: Tambien conocidas como apis internas, se utilizan para conectar diferentes componentes de softwares dentro de una misma organizacion, y no s eencuentran disponibles para el uso de terceros.

            * APIs Publicas: Proporcionan acceso publico a los datos, funciones o servicios de una organizacion que los desarrolladores de terceros pueden integrar a sus propias aplicaciones. Algunas de estas estan disponibles de forma gratuita, mientras que otras estan disponibles solo despues de efectuar su pago

            * APIs de Socios: Permiten que dos o mas empresas compartan datos o funcionalidad para poder colaborar en un proyecto. No se encuentran disponibles para el publico en general, y por lo tanto utilizan mecanismos de autenticacion para garantizar que solo sean utilizados por socios autorisados.

            "De alguna forma siempre estamos haciendo una API en nuestro software para que alguna que otras piezas de software la utilicen"
        
        COMUNICAION ENTRE DISPOSITIVOS:
        ******************************
            Formas de comunicacion:

            * Simplex: En este modo solo es posible la transmicion en un sentido, del terminal que origuina la informacion hacia el que la recive y procesa. Ej: emisoras de radiodifucion.

            * Semiduplex (Half-duplex): Permite la transmicion en ambos sentidos de manera alterna.

            * Duplex (full-Duplex): Consiste en la transmicion en ambos sentidos de manera simultanea. Es la forma de cominicacion mas eficiente, ej: comunicacion telefonica.
            
        
    API REST (REpresentación, la S de Estado y la T de Transferencia.)
    ********

        Una API REST es una interfaz de comunicacion entre sistemas de informacion que usa el protocolo de transferencia de hipertexto (hypertext transfer protocol o HTTP, por su siglas en inglés) para obtener datos o ejecutar operaciones sobre dichos datos en diversos formatos, como pueden ser XML o JSON

        Una API es RESTful si cumple con los estándares API REST.


        RESTRICCIONES DE REST:
        *********************

        Las restricciones determinadas por la arquitectura rest son:

        * Cliente-Servidor: Las aplicaciones existentes en el servidor y el cliente deben estar separados.
        * Sin estado: Las requisiciones se realizan de forma independientes, es decir cada una ejecuta una determinada accion.
        * Cache: La api deve utilizar la cache para evitrar las llamadas recurrentes al servidor.
        * Interfaz Uniforme: Cada recurso deve tener un unico identificador uniforme de recurso (ruta).


        ARQUITECTURA CLIENTE-SERVIDOR:
        ******************************

            La arquitectura cliente-servidor es un modelo de diseño de software en el que las tareas se reparten entre los proveedores de recursos o servicios, llamados servidores, y los demandantes, llamados clientes. Un cliente realiza peticiones a otro programa, el servidor, quien le da respuesta.

            En esta arquitectura el modelo, cliente-servidor ayuda en la separación de responsabilidades entre la interfaz de usuario y el almacenamiento de datos. Es decir, cuando se realiza una solicitud REST, el servidor envía una representación de los estados que se solicitaron.

        
        USOS Y FUNCIONES DE APRI REST:
        *****************************
            Una API Rest permite que la aplicación acceda a bases de datos desde diferentes servidores, lo que a menudo es importante para el desarrollo en aplicaciones grandes. Por lo tanto, su uso garantiza una mayor visibilidad y credibilidad a la hora de utilizar estos recursos.

        
    
    PROTOCOLO HTTP: Hyper-Text Transfer Protocol
    **************

        La comunicación en HTTP se centra en un concepto llamado ciclo de solicitud-respuesta. El cliente envía al servidor una  solicitud (Request HTTP) para haceralgo. El servidor, a su vez, puede devolver al cliente una respuesta (Response HTTP) diciendo si el servidor puede o no hacer lo que el cliente pidió.

        Los mensajes HTTP están compuestos de texto, codificado en ASCII, y pueden comprender múltiples líneas. En HTTP/1.1, y versiones previas del protocolo, estos mensajes eran enviados de forma abierta a través de la conexión. En HTTP/2.0 los mensajes, que anteriormente eran legibles directamente, se conforman mediante tramas binarias codificadas para aumentar la optimización y rendimiento de la transmisión.



        Estructura de un REQUEST HTTP (Petición HTTP)
        ********************************************

            •Verbo − Indica que método HTTP se utiliza, puede ser GET, POST, DELETE, PUT, etc.
            •URI − Uniform Resource Identifier (URI) identifica la ruta al recurso que se hace referencia
            •HTTP Version − Indica la versión HTTP. Por ejemplo, HTTP v1.1.
            •Request Header − Contiene Metada para el Request HTTP estructurado como pares de (Llave-Valor). Como son: cliente (o Navegador) tipo, formato soportado por el cliente, formato del mensaje (body), cache settings, etc.
            •Request Body − (opcional) Contenido del mensaje.

        Ejemplo Query String
        ********************
            Podemos pasar parámetros al servidor incluyéndolos en la URL. Normalmente se componen por un nombre y un valor separados por el signo igual, pudiéndose concatenar un número arbitrario de ellos mediante el signo &. Un ejemplo:

                www.localhost.com/Accion?parámetro1=valor1&parámetro2=valor2


        Verbos HTTP
        ***********
            * GET: El método GET es el método más común, generalmente se usa para solicitar a un servidor que envíe un recurso. Los parámetros los puede ver cualquiera persona simplemente mirando la URL de la web y los parámetros que esta lleva.

            * POST: POST consiste en datos "ocultos" (porque el cliente no los ve) enviados por un formulario cuyo método de envío es post. Es adecuado para formularios. Los datos no son visibles en la url.

            * PUT: Utilizado normalmente para actualizar contenidos, pero también pueden crearlos. Tampoco muestra ninguna información en la URL

            * DELETE: Elimina un recurso identificado en la URI. Si se elimina correctamente devuelve 200 (OK) junto con un body response, o 204 sin body

            * HEAD: Es idéntico a GET, pero el servidor no devuelve el contenido en el HTTP response. Cuando se envía un HEAD request, significa que sólo se está interesado en el código de respuesta y los headers HTTP, no en el propio documento.
        

        Estructura de un RESPONSE HTTP (Petición HTTP)
        **********************************************

            • Status/Response Code − Indica el estado del servidor para lo que se solicitó. Por ejemplo, 404 significa que un recurso no fue encontrado y 200 significa que una respuesta es OK.
            
            • HTTP Version − indica la versión de HTTP utilizada. Por ejemplo HTTP v1.1. 
            
            • Response Header − Contiene metada de la respuesta HTTP como pares Llave-valor. Por ejemplo, content length, content type, response date, server type, etc.
            
            • Response Body (opcional) − Contenido del mensaje de respuesta o representación del rescurso solicitado.

                EJEMPLO DE POST:

                    POST http://MyService/Person/ HTTP/V2.0
                    Host: MyService
                    Content-Type: text/Json; charset=utf-8
                    Content-Length: 123
                    {
                        "Person":
                        {
                            "ID": 1,
                            "Name": “Pablo Paramo",
                            "Email": “pparamo@gmail.com",
                            "Country": “Argentina"
                        }
                    }
        
        Los códigos de estado (Status/Response Code) de respuesta HTTP indican si se ha completado satisfactoriamente una solicitud HTTP específica. Las respuestas se agrupan en cinco clases:
            • Respuestas informativas (100–199),
            • Respuestas satisfactorias (200–299),
            • Redirecciones (300–399),
            • Errores de los clientes (400–499),
            • y errores de los servidores (500–599).

        Los códigos de estado (Status/Response Code) más utilizados son:
            •200 (OK) solicitud cumplida con éxito.
            •201 (Created) objeto o recurso creado con éxito.
            •204 (Non Content) objeto o recurso eliminado con éxito.
            •400 (Bad Request) ocurrió un error en la solicitud.
            •404 (Not Found) ruta o colección no encontrada.
            •500 (Internal Server Error), se ha producido algún error del servidor.

*/