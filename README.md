# vertivina
Un simple repositorio de prueba.<br/>
Si es posible, nos lo quedamos<br/>

&#128272
Este comando lo saque de una pagina de "codigos" nos permite crear las figuritas de la llave y el candado, que aparecen en nuestros input de texto y contraseña respectivamente ... pensare si crear una pagina de css difente o colocar los estilos en la misma pestaña login.<br/>

Glosario:<br/>

*Para las migraciones (cada vez que se tiene que hacer cambios tanto a las clases como a la base): <br/>
 <br/>
  dotnet ef migrations add [Nombre de migración. Debe ser diferente a la anterior] <br/>
Gente tengo problemas con el ultimo commit, no puedo habrir la vista cita, ni promociones, quien demonios, cambio algo <br/>
<br/>
Recordatorio: No borren las migraciones a menos que sea una verdadera emergencia o se quiera hacer desde cero
 <br/>
*Para autogenerar codigo: <br/>
 <br/>
 *tengo problemas en cita, y promociones, lo mas raro esque en mis tablas se crea, producto y cita, pero no puedo visualizarlas.<br/>

  dotnet aspnet-codegenerator controller -name [Nombre de nuevo controlador] -m [Clase] -dc [Clase contexto] --relativeFolderPath     Controllers --useDefaultLayout --referenceScriptLibraries 
 <br/>
 Si existe algun problema con los comandos: <br/>
 *Asegurense de tener su .Net core actualizado (la ultima version es 2.1) <br/>
 *Realizen el dotnet restore <br/>
 *Eliminen las carpetas obj y bin, despues realicen el build<br/>
 *Revisen que el paquete tools.dotnet este ahi <br/>
 
 ```
   <ItemGroup> 
     <DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="2.0.3" /> 
    <DotNetCliToolReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Tools" Version="2.0.4" /> 
  </ItemGroup>

```
Estos van en el segundo grupo ItemGroup del csproj

O alternativamente, bajense el paquete de entity framework core completo <br/>
```
<ItemGroup>
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="2.1.4" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="2.1.4" />
  </ItemGroup>

```
Estos van al primer ItemGroup csproj

Recuerden: estos paquetes deben estar en el csproj
 *Si existen errores incluso despues de restaurar los paquetes, reinicen el editor
 
 
