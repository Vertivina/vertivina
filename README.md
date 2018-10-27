# vertivina
Un simple repositorio de prueba.<br/>
Si es posible, nos lo quedamos<br/>

Glosario:<br/>

*Para las migraciones (cada vez que se tiene que hacer cambios tanto a las clases como a la base): <br/>
 <br/>
  dotnet ef migrations add [Nombre de migración. Debe ser diferente a la anterior] <br/>
  dotnet ef database update<br/>
<br/>
Recordatorio: No borren las migraciones a menos que sea una verdadera emergencia o se quiera hacer desde cero
 <br/>
*Para autogenerar codigo: <br/>
 <br/>

  dotnet aspnet-codegenerator controller -name [Nombre de nuevo controlador] -m [Clase] -dc [Clase contexto] --relativeFolderPath     Controllers --useDefaultLayout --referenceScriptLibraries 
 <br/>
 Si existe algun problema con los comandos: <br/>
 *Asegurense de tener su .Net core actualizado (la ultima version es 2.1) <br/>
 *Realizen el dotnet restore <br/>
 *Revisen que el paquete tools.dotnet este ahi <br/>
 
   <ItemGroup> <br/>
     <DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="2.0.3" /> <br/>
    <DotNetCliToolReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Tools" Version="2.0.4" /> <br/>
  </ItemGroup> <br/>
<br/>
O alternativamente, bajense el paquete de entity framework core completo <br/>
<ItemGroup><br/>
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="2.1.4" /><br/>
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="2.1.4" /><br/>
  </ItemGroup><br/>
<br/>

 *Si existen errores incluso despues de restaurar los paquetes, reinicen el editor
 
 
