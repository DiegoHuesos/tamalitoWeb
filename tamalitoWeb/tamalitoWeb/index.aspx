<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="tamalitoWeb.index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<title>Tamal-ito!</title>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1"> 
	<link rel="stylesheet" href="./css/indexStyle.css">
</head>
<body> 
	<form id="form1" runat="server">
	<!-- HEADER -->
	<div id="mainHeader">
		<!-- Logo -->
		<div id="logo"> <h1><a href="#">Tamal-ito!</a></h1> </div>

		<!--navBar-->
		<nav id="navBar">	<!--The <nav> tag defines a set of navigation links.-->
			<ul>
				<li><a href="#">Inicio</a></li>
				<li><a href="#nosotros">Nosotros</a></li>
				<li><a href="#contact">Contacto</a></li>
				<li><a href="./InicioSesion.aspx">Log-In</a></li>
				<li><a href="./Registro.aspx">Sign-In</a></li>
			</ul>
		</nav>	
	</div>

	<!-- CATÁLOGO -->
	<div id="container-categories">
		<div class="subtitle"><h1>¡Llévele, llévele!</h1></div>
			
		<div class="box-category">
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

	<!-- NOSOTROS -->
	<br>
	<div id="nosotros">
		<div class="subtitle"><h1>Nosotros</h1></div>

		<div class="sidebar-right">
			<p>"Tamales, atole y felicidad" </p>
			<img src="./images/caras/Diego.png" alt="Diego picture" height="150" width="150">
			<p>Diego Hernández (CIO)</p>
		</div>
		<div class="sidebar-right">
			<p>"Aquí no damos atole con el dedo, aquí lo damos en vaso" </p>
			<img src="./images/caras/JoseCarlos.png" alt="José Carlos picture" height="150" width="150">
			<p>José Carlos (COO)</p>
		</div>
		<div class="sidebar-right">
			<p>"Cuiden sus carteras o yo las cuido por ustedes." </p>
			<img src="./images/caras/Angel.png" alt="Angel picture" height="150" width="150">
			<p>Ángel (CFO)</p>
		</div>

		<div id="what-is">
			<p id="description">Somos un grupo de estudiantes itamitas que buscamos ofrecer una alternativa gastronómica basada en uno de los platillos más icónicos de la cultura mexicana. Así mismo, los productos serán de bajo costo para que cualquier estudiante pueda tener acceso a estos manjares. Por si fuera poco, gracias a esta aplicación web, cualquiera puede ordenar y pagar desde la comodidad de un dispositivo inteligente.  </p>
		</div>
	</div>

	<div id="line"></div>

	<!-- CONTACTO -->
	<div id="contact">
		<div class="subtitle"><h1>Contacto</h1></div>
        <div class="map" style="margin-right:5%;">
        </div>
		<div id="contact-details">

			

			</div>
				<br>
				<h1>Echanos un grito:<asp:Image ID="Image1" runat="server" ImageUrl="~/Resources/maps.jpg" AlternateText="Mapa oficina" CssClass="img" Height="219px" ImageAlign="Right" Width="263px"/>
        </h1>
				<h2> &nbsp &nbsp atencion@tamalito.itam</h2>
				<h2> &nbsp &nbsp +55 3478 5643</h2>
				<br>
				<h2>Síguenos en:</h2>
		
				<span id="follow-us">

						<div class="cont-sm">
							<img class="sc-img" src="./images/socialMedia/Facebook1.png">
						</div>
						
						<div class="cont-sm">
							<img class="sc-img" src="./images/socialMedia/insta1.png">
						</div>
						
						<div class="cont-sm">
							<img class="sc-img" src="./images/socialMedia/Twitterbird.png">
						</div>
							
				</span>
			</div>	
			

		</div>	
		
		
	</div>	


	<!-- FOOTER -->
	<footer id="mainFooter"> 
		<h3>Copyright &copy;  Tamal-ito!</h3>
	</footer>

	<!-- GOOGLE-MAPS CODE -->
	<script>
        function myMap() {
            var mapOptions = {
                center: new google.maps.LatLng(51.5, -0.12),
                zoom: 10,
                mapTypeId: google.maps.MapTypeId.HYBRID
            }
            var map = new google.maps.Map(document.getElementById("map"), mapOptions);
        }
	</script>
		
	<script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBu-916DdpKAjTmJNIgngS6HL_kDIKU0aU&callback=myMap"></script>

    </form>

</body>
</html>