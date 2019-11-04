<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmarCompra.aspx.cs" Inherits="tamalitoWeb.ConfirmarCompra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<title>Confirmar Compra | Tamalito</title>
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
    <h2 id="lbTitle">Su Orden</h2>
    <form id="form1" class="box" runat="server">
        <div>
            <asp:GridView ID="gvOrden" runat="server"></asp:GridView>
            <br />
            <asp:Label ID="lbTotalOrden" runat="server" Text="Total Orden:"></asp:Label>
            <asp:Label ID="lbTotal" runat="server" Text="$0"></asp:Label>
            <br />
            <asp:Button ID="btConfirmarPedido" runat="server" Text="Generar Pedido" class="btConfirmar" OnClick="btConfirmarPedido_Click"/>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
