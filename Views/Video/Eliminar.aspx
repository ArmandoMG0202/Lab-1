<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Eliminar</title>
</head>
<body>
  
    <a href="/Home/Index">Ver Opciones</a>
 <form action="/video/Eliminar" method="post">
<fieldset>

<legend>Datos del video</legend>

<label for="idVideo">IdVideo</label>
<input type="text" name="idVideo" />

<input type="submit" value="Registro" />

    <div>

    </div>
</body>
</html>
