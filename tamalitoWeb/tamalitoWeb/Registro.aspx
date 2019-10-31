<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="tamalitoWeb.Registro" %>

<!DOCTYPE html>
<html lang="es" dir="ltr" xmlns="http://www.w3.org/1999/xhtml">
<head>
 <meta charset="utf-8"/>
 <title>Animated Login Form</title>
 <link rel="stylesheet" href="./css/registro.css" />
</head>
<body>
    <div id="mainHeader">
		<!-- Logo -->
		<div id="logo"> <h1><a href="#">Tamal-ito!</a></h1> </div>

		<!--navBar-->
		<nav id="navBar">	<!--The <nav> tag defines a set of navigation links.-->
			<ul>
				<li><a href="./index.aspx">Inicio</a></li>
				<li><a href="./InicioSesion.aspx">Log-In</a></li>
			</ul>
		</nav>	
	</div>
 <form class="box" action="log.html" method="post">
  <h1>Registrarse</h1>
  <input type="text" name="" placeholder="Nombre"/>
  <input type="text" name="" placeholder="Apellido Paterno"/>
  <input type="text" name="" placeholder="Apellido Materno"/>
  <input type="text" name="" placeholder="Correo"/>
  <input type="text" name="" placeholder="Número de Tarjeta"/>
  <input type="submit" name="" placeholder="Submit"/>
 </form>



</body>

</html>

