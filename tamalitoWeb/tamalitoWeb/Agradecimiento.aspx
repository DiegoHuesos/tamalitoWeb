<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agradecimiento.aspx.cs" Inherits="tamalitoWeb.Agradecimiento" %>

<!DOCTYPE html>
<html lang="es" dir="ltr" xmlns="http://www.w3.org/1999/xhtml">
<head>
 <meta charset="utf-8"/>
 <title>Agradecimiento | Tamalito</title>
 <link rel="stylesheet" href="./css/agradecimiento.css" />
</head>
<body>
    <div id="mainHeader">
		<!-- Logo -->
		<div id="logo"> <h1><a href="#">Tamal-ito!</a></h1> </div>

		<!--navBar-->
		<nav id="navBar">	<!--The <nav> tag defines a set of navigation links.-->
			<ul>
                <li><a href="./Ordenar.aspx">Ordenar</a></li>
				<li><a href="./LogOut.aspx">Log-Out</a></li>
			</ul>
		</nav>	
	</div>
    

    <form id="Form2" class="box" runat="server">
        <div id="idunico" runat="server">
            <asp:Label ID="lbAgradecimiento" class="d" runat="server" Text="¡Muchas gracias por tu compra!" ForeColor="White" Font-Size="XX-Large"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="lbAyuda" class="d" runat="server" Text="Con cada compra ayudas a las tortugas itamitas." ForeColor="White" Font-Size="XX-Large"></asp:Label>
        </div>
    </form>

</body>

</html>