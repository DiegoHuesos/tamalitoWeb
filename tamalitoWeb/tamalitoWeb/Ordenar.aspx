<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ordenar.aspx.cs" Inherits="tamalitoWeb.Ordenar" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<title>Tamal-ito!</title>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1"> 
	<link rel="stylesheet" href="./css/ordenar.css">
</head>
<body> 
	<!-- HEADER -->
	<div id="mainHeader">
		<!-- Logo -->
		<div id="logo"> <h1><a href="#">Tamal-ito!</a></h1> </div>

		<!--navBar-->
		<nav id="navBar">	<!--The <nav> tag defines a set of navigation links.-->
			<ul>
				<li><a href="./index.aspx">Inicio</a></li>
				<li><a href="./index.aspx">Log-Out</a></li>
			</ul>
		</nav>	
	</div>

	<!-- CATÁLOGO -->
	<div id="container-categories">
		<div class="subtitle"><h1>¡Llévele, llévele!</h1></div>
		<input type="submit" class="botonverde"/>
		<div type="submit" class="box-category">
			<div id ="Abstract-img" class="img-category">
				<img src="./images/tamales/verde.jpg" alt="Tamal Verde">
				<h1>Verde</h1>
			</div>
		</div>

		<div class="box-category">
			<div id ="Wooden-img" class="img-category">
				<img src="./images/tamales/rojo.jpg" alt="Tamal Rojo">
				<h1>Rojo</h1>
			</div>
		</div>
			
		<div class="box-category">
			<div id ="Sport-img" class="img-category">
				<img src="./images/tamales/mole.jpg" alt="Tamal de Mole">
				<h1>Mole</h1>
			</div>
		</div>
			
			
		<div class="box-category">
			<div id ="Smart-img" class="img-category">
				<img src="./images/tamales/dulce.jpg" alt="Tamal Dulce">
				<h1>Dulce</h1>
			</div>	
		</div>
			
	</div>

	<div id="line"></div>

	
</body>
</html>
