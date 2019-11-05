<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="tamalitoWeb.InicioSesion" %>

<!DOCTYPE html>
<html lang="es" dir="ltr" xmlns="http://www.w3.org/1999/xhtml">
<head>
 <meta charset="utf-8"/>
 <title>Animated Login Form</title>
 <link rel="stylesheet" href="./css/iniciarsesion.css" />
</head>
<body>
    <div id="mainHeader">
		<!-- Logo -->
		<div id="logo"> <h1><a href="#">Tamal-ito!</a></h1> </div>

		<!--navBar-->
		<nav id="navBar">	<!--The <nav> tag defines a set of navigation links.-->
			<ul>
				<li><a href="./index.aspx">Inicio</a></li>
				<li><a href="./Registro.aspx">Sign-In</a></li>
			</ul>
		</nav>	
	</div>
    

    <form id="Form1" class="box" runat="server">
        <div id="idunico" runat="server">
            <asp:Label ID="lbTitle" runat="server" Text="Iniciar sesión"></asp:Label>
            <br />
            <br />
            <br />
            <asp:TextBox id="User" class="inp" runat="server" placeholder="Username"/>
            <br />
            <asp:TextBox id="Password" class="inp" runat="server" placeholder="Password"/>
            <br />
            <asp:Button text="Iniciar" id="Enviar" class="bt" runat="server" OnClick="Enviar_Click"/>
            <br />
            <br />
            <asp:Label ID="lbRegistroNuevo" runat="server" Text="" ForeColor="White"></asp:Label>
            <br />
        </div>
    </form>

</body>

</html>
