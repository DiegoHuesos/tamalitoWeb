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
    <form id="Form1" class="box" runat="server">
        <div id="idunico"  runat="server">
            <asp:Label ID="lbTitle" runat="server" Text="REGISTRARSE"></asp:Label>
            <br />
            <asp:TextBox id="Nombre" class="inp" runat="server" placeholder="Nombre"/>
            <br />
            <asp:TextBox id="ApellidoPaterno" class="inp" runat="server" placeholder="Apellido Paterno"/>
            <br />
            <asp:TextBox ID="ApellidoMaterno" class="inp" runat="server" placeholder="Apellido Materno"/>
            <br /> 
            <asp:TextBox ID="Correo" class="inp" runat="server" placeholder="Correo Electrónico"/>
            <br />
            <asp:TextBox ID="numTarjeta" class="inp" runat="server" placeholder="Número de Tarjeta"/>
            <br />
            <asp:TextBox ID="contrasenia" class="inp" runat="server" placeholder="Password"/>
            <br />
            <asp:Button text="Enviar" id="Enviar" class="bt" runat="server" OnClick="Enviar_Click"/>
            <br />
        </div>
    </form>
    
    <br />
    <br />
    <br />
    <br />

</body>

</html>

