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
    <h2 id="lbTitle">¡Pide lo que quieras!</h2>
    <form id="Form1" class="box" runat="server">

        <div class="productos">
        <div class="rows">
            <div id="divVerde" class="cards">
                <asp:Label ID="lbVerdePrecio" class="lb" runat="server" Text="$20"></asp:Label>
                <asp:ImageButton ID="btVerde" runat="server" src="./images/tamales/verde.jpg" class="bt" OnClick="btVerde_Click"/>
                <asp:DropDownList ID="ddVerde" class="ddl" runat="server" AutoPostBack="True"  OnTextChanged="ddVerde_TextChanged" OnSelectedIndexChanged="ddVerde_SelectedIndexChanged"></asp:DropDownList>
            </div>
            <div class="cards">
                <asp:Label ID="lbRojoPrecio" class="lb" runat="server" Text="$20"></asp:Label>
                <asp:ImageButton ID="btRojo" runat="server" src="./images/tamales/rojo.jpg" class="bt"/>
                <asp:DropDownList ID="ddRojo" class="ddl" runat="server" AutoPostBack="True"></asp:DropDownList>
            </div>
            <div class="cards">
                <asp:Label ID="lbMolePrecio" class="lb" runat="server" Text="$20"></asp:Label>
                <asp:ImageButton ID="btMole" runat="server" src="./images/tamales/mole.jpg" class="bt"/>
                <asp:DropDownList ID="ddMole" class="ddl" runat="server" AutoPostBack="True"></asp:DropDownList>
            </div>
            <div class="cards">
                <asp:Label ID="lbDulcePrecio" class="lb" runat="server" Text="$20"></asp:Label>
                <asp:ImageButton ID="btDulce" runat="server" src="./images/tamales/dulce.jpg" class="bt"/>
                <asp:DropDownList ID="ddDulce" class="ddl" runat="server" AutoPostBack="True"></asp:DropDownList>
            </div>
        </div>
        <div class="rows">
            <div class="cards">
                <asp:Label ID="lbAtoleVainillaPrecio" class="lb" runat="server" Text="$10"></asp:Label>
                <asp:ImageButton ID="btAtoleVainilla" runat="server" src="./images/atoles/vainilla.jpg" class="bt"/>
                <asp:DropDownList ID="ddAtoleVainilla" class="ddl" runat="server" AutoPostBack="True"></asp:DropDownList>
            </div>
            <div class="cards">
                <asp:Label ID="lbAtoleChocolatePrecio" class="lb" runat="server" Text="$10"></asp:Label>
                <asp:ImageButton ID="btAtoleChocolate" runat="server" src="./images/atoles/chocolate.jpg" class="bt"/>
                <asp:DropDownList ID="ddChocolate" class="ddl" runat="server" AutoPostBack="True"></asp:DropDownList>
            </div>
            <div class="cards"> 
                <asp:Label ID="lbAtoleFresaPrecio" class="lb" runat="server" Text="$10"></asp:Label>
                <asp:ImageButton ID="btAtoleFresa" runat="server" src="./images/atoles/fresa.jpg" class="bt"/>
                <asp:DropDownList ID="ddAtoleFresa" class="ddl" runat="server" AutoPostBack="True"></asp:DropDownList>
            </div>
            <div class="cards">
                <asp:Label ID="lbAtoleArrozPrecio" class="lb" runat="server" Text="$10"></asp:Label>
                <asp:ImageButton ID="btAtoleArroz" runat="server" src="./images/atoles/arroz.jpg" class="bt"/>
                <asp:DropDownList ID="ddAtoleArroz" class="ddl" runat="server" AutoPostBack="True"></asp:DropDownList>
            </div>
        </div>
    </div>
        <br />
        <br />
        <asp:GridView ID="gvOrden" runat="server"></asp:GridView>
        <br />
        <asp:Label ID="lbTotalOrden" runat="server" Text="Total Orden:"></asp:Label>
        <asp:Label ID="lbTotal" runat="server" Text="$0"></asp:Label>
        <br />
        <asp:Button ID="btConfirmar" runat="server" Text="Confirmar Compra" class="btConfirmar"/>
        <br />
        <br />
    </form>
    

	
</body>
</html>
