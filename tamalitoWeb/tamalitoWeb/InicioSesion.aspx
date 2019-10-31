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
    <form id="form1" runat="server">
        <h1>Login</h1>
        <input id="username" runat="server"  placeholder="Username" type="text" />
 
        <input type="password" name="" placeholder="Password" id="password"/>
        <button type="submit" name="" placeholder="Submit" onclick="submit"/>
         
        <asp:Button ID="submit" runat="server"  Text="Submit" OnClick="submit_Click" />
    </form>

</body>

</html>
