# PruebaTecnica

1.	Descripción de Proyecto 

-	El backend de la API sigue una arquitectura de capas que comprende controladores para Autores y Libros, interfaces de servicio que definen operaciones, clases de servicio con la lógica     de negocio para guardar y consultar los objetos Autores y Libros, una interfaz de repositorio para las operaciones en la Base de Datos el cual hereda un repositorio base con funciones      (Guardar, Modificar, Consultar por Id, Consultar todos y Eliminar), clases modelo y configuración para mapear objetos en la base de datos, y configuración en la clase Startup para       
  garantizar la conexión adecuada entre estos componentes.

-	El frontend implementa una estructura que incluye el HTML, que comprende una tabla de libros y dos modales para agregar autores y libros. Además, se utiliza un conjunto de tres archivos    JavaScript: uno general y dos específicos para las operaciones relacionadas con cada tipo de objeto, los cuales consumen la API correspondiente. Asimismo, se incluye un archivo CSS que     contiene una configuración básica para el diseño de la página, y se aprovecha la incorporación de Bootstrap a través de un CDN para mejorar la apariencia y la usabilidad del sitio web.

-	En la Base de Datos se crean dos tablas: "Autores" con las columnas "idAutores" y "Titulo", y "Libros" con las columnas "IdLibro", "Nombre", e "IdAutor". Se establece una relación entre    el atributo "IdAutor" en la tabla "Libros" como una clave foránea que referencia la tabla "Autores".

2.	Pasos para configurar y ejecutar la aplicación.

  Configurar

-	Configurar la ruta de conexión a la base de datos en el archivo appsettings.json ubicada en la carpeta Prueba Tecnica\ServicesLibrary\ServicesLibrary en la variable "DefaultConnection"
  ![image](https://github.com/ManuelRomero0310/PruebaTecnica/assets/150102075/be01dd56-d29a-4ee4-a725-86b6c8f419e5)

-	Cambiar la ruta de la API del javascript si esta cambia y se valida en estros tres archivos de javascrip.
  index.js linea 2 en la variable response (consultar libros)
  ![image](https://github.com/ManuelRomero0310/PruebaTecnica/assets/150102075/73c316f1-ba3e-47e3-84c6-983fe9619d02)
  author.js linea 21 variable response (Guardar autor)
  ![image](https://github.com/ManuelRomero0310/PruebaTecnica/assets/150102075/14cdf29f-7d95-4fdd-ac2d-a3100e4611cb)
  book.js linea 2 y 49 de la variable response (Consultar autores) y (Guardar Libro)
 	![image](https://github.com/ManuelRomero0310/PruebaTecnica/assets/150102075/575f4d82-9e99-48f6-b955-9110d42517ce)
 	![image](https://github.com/ManuelRomero0310/PruebaTecnica/assets/150102075/f3d98bef-4c66-4c44-ae16-d0c26dc45a8c)

  Ejecutar

  - Abrir la carpeta service y ejecute el archivo ServicesLibrary.sln en visual studio y ejecute el programa
  - Abrir en visual code la carpeta FrontendWebLibrary con sus respectivos archivos y ejecute el index.html

 	3. Capturas de pantalla de las principales funcionalidades de la aplicación.

  - API en swagger
    ![image](https://github.com/ManuelRomero0310/PruebaTecnica/assets/150102075/1d00fe15-9b85-44dd-af29-9f858e3ded98)

  - Ventana principal tabla de los libros con sus autores
    ![image](https://github.com/ManuelRomero0310/PruebaTecnica/assets/150102075/02247b33-51b1-43bc-9a64-54f437546564)

  - Modal guardar autor
    ![image](https://github.com/ManuelRomero0310/PruebaTecnica/assets/150102075/5f5725e8-c35a-4f85-8f3f-06c37fd8b2fb)

  - Modal guardar libro
    ![image](https://github.com/ManuelRomero0310/PruebaTecnica/assets/150102075/03c57e9e-3135-4d17-b57f-dcc4bea42996)
    
4. Diagrama entidad relación de la base de datos

- ![image](https://github.com/ManuelRomero0310/PruebaTecnica/assets/150102075/7a9586d0-9865-461d-9a92-bf3a07e8b2a0)

- ![image](https://github.com/ManuelRomero0310/PruebaTecnica/assets/150102075/3c62d12f-9d1b-4cde-9ec0-ef9b9d15777d)



