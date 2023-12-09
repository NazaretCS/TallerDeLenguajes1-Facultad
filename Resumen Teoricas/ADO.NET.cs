/*

    Conectando a una Bases de datos con ADO.NET
    *******************************************

        Herramientas para trabajar Bases de datos con c#

            ADO.NET es un conjunto de clases que exponen servicios de acceso a datos para programadores de .NET Framework. ADO.NET ofrece abundancia de componentes para la creación de aplicaciones de uso compartido de datos distribuida.

        Componentes de ADO Net.
        **********************

            -> Connection: Permite establecer una conexión con la base de datos.
            -> Command: Permite enviar órdenes SQL para ser ejecutados por la base de datos.
            -> DataReader: Permite leer un flujo de filas de solo avance desde una base de datos.


        Cadena de conexión
        ******************
            • Una cadena de conexión contiene información de inicialización que se transfiere como un parámetro desde un proveedor de datos a un origen de datos.
            • Suele ser un conjunto de claves y valores separados por punto y coma “;”. El conjunto de claves y valores esta conectado por el signo de igual por ejemplo clave1=valor1;clave2=valor2.
            • El conjunto de claves y valores disponibles están definidos por el proveedor de la base de datos y muchas veces hay inconsistencias entre las claves de diferentes proveedores de base de datos.


        Cadena de conexión para sqlite
        ******************************

            string CadenaDeConexion = "Data Source=InstitutoDb.db;Cache=Shared“ ;


        La clase Connection
        *******************

            • Podemos utilizar el objeto Connection para conectar a una fuente de datos específica.
            • Establece y gestiona una conexión a una fuente de datos específica.
            • método Open() que abre la conexión
            • método Close() que cierra la conexión a la base de datos
            string connectionString = "Data Source=(local);Initial Catalog=Northwind;" + "Integrated Security=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open(); -----> Para abrir la concexion 
                [….]
                connection.Close();  -------> Para cerrar la concexion 
            }



        La clase Command()
        ******************

            • Permite especificar las órdenes, generalmente en SQL, permite consultar y modificar el contenido de la base de datos: Select, Insert, Delete y Update.
            • Recibe como referencia una conexión y un comando SQL
            • Devuelve un Objeto DataReader() con los resultados
            • Métodos parameters() para pasar parámetros al comando SQL de forma segura.

            string queryString = "SELECT Nombre, FechaNacimiento FROM dbo.Empleados;";
            var command = new SqlCommand( queryString, connection);
            connection.Open();
            using(var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {[…]} // Resultados obtenidos (1 fila por vez)
            }



            Posibles forma de ejecutar con Command()

                -> ExecuteReader: Ejecuta comandos que devuelven filas. Se utiliza normalmente con las Instrucciones SELECT
                -> ExecuteNonQuery: Ejecuta comandos como las instrucciones INSERT, DELETE, UPDATE.
                                command.ExecuteNonQuery();
                -> ExecuteScalar: Recupera un valor único de una base de datos.
                                Int IdBuscado = (Int32)command.ExecuteScalar();



        Resultados de una solicitud  : La clase DataReade
        *************************************************

            • Permite realizar lecturas forma eficiente de grandes cantidades de datos que no caben en memoria de una sola vez.
            • Provee solo acceso de modo lectura, no puede escribir datos en la base de datos.
            • Representación en memoria de una fila (Row) de una Tabla.
            • Permite recorrer la Tabla (solo hacia abajo) de fila en fila.
            • Muestra los datos siempre y cuando se mantenga conectado a la base de datos. Si la conexión se pierde, los datos también.
            • Accedemos a las columnas de una DataReader con corchetes 

                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0}, {1}", reader[0], reader[1]));
                    }
                }

            Pasos para operar con ADO.NET
            *****************************

            • Seteamos el tipo de conexión, especificamos la fuente de datos. En el Objeto Connection.
            • Abrimos la conexión a la fuente de datos en el objeto Connection 
            {
                • Ejecutamos un comando SQL en la base de datos usando la clase Command()
                • Si el comando devuelve datos (Select)
                {
                    • Debemos usar command.ExecuteReader() que nos devuelve un objeto DataReader();
                    • Leer los datos devueltos por el objeto DataReader();
                }
                • Si el comando NO devuelve (Update, Insert, Delete)
                {
                    • Se ejecuta y nos tira una excepción si algo salió mal
                }
            }
            • Cerramos la conexión después de trabajar con los datos en el objeto Connection.


            Ejemplo completo de ADO Net
            ****************************

                private static void GetEmpleados(string connectionString)
                {
                    string queryString = "SELECT Nombre, IDEmpleado FROM dbo.Empleado;";
                    using (SqliteConnection connection = new SqliteConnection(connectionString))
                    {
                        SqliteCommand command = new SqliteCommand(queryString, connection);
                        connection.Open();
                        using(SqliteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine(String.Format("{0}, {1}",reader[0], reader[1]));
                            }
                        }
                    connection.Close();
                    }
                }



            Almacenar cadena de conexión
            *****************************
            El archivo appsettings.json es un archivo de configuración de la aplicación que se utiliza para almacenar las opciones de configuración, como las cadenas de conexiones de la base de datos, las variables globales del ámbito de la aplicación, etc.
            Este archivo se crea con el Template de ASP net core: Empty Project template or Razor Pages or MVC Template or Web API Template.



*/  