﻿using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tamalitoWeb
{
    public partial class Ordenar : System.Web.UI.Page
    {
        //ATRIBUTOS O VARIBALES GLOBALES:
        List<ObjSelec> carrito = new List<ObjSelec>();
        int precioVerde;
        int precioRojo;
        int precioMole;
        int precioDulce;
        int precioArroz;
        int precioVainilla;
        int precioFresa;
        int precioChocolate;
        int subTotal = 0;
        int total = 0;

        
        //DICCIONARIOS PARA SABER LA CANTIDAD SELECCIONADA DE CADA PRODUCTO:
        Dictionary<String, int> cantSeleccionada = new Dictionary<String, int>()
        {
            ["verde"] = 0,
            ["rojo"] = 0,
            ["mole"] = 0,
            ["dulce"] = 0,
            ["arroz"] = 0,
            ["vainilla"] = 0,
            ["fresa"] = 0,
            ["chocolate"] = 0
        };


        protected OdbcConnection conectarBD()
        {
            String stringConexion = "Driver={SQL Server Native Client 11.0};Server=localhost;Uid=sa;Pwd=sqladmin;Database=tamalito";
            try
            {
                OdbcConnection conexion = new OdbcConnection(stringConexion);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                if (!IsPostBack)//Aquí llenamos los Drop Down List para que el cliente puedar ordenar la cantidad deseada de cada prodcuto, con un máximo de 10 unidades en cada uno
                {
                    while (i <= 10)
                    {
                        ddVerde.Items.Add(i + "");
                        ddRojo.Items.Add(i + "");
                        ddMole.Items.Add(i + "");
                        ddDulce.Items.Add(i + "");
                        ddAtoleVainilla.Items.Add(i + "");
                        ddChocolate.Items.Add(i + "");
                        ddAtoleFresa.Items.Add(i + "");
                        ddAtoleArroz.Items.Add(i + "");
                        i++;
                    }

                }
                OdbcConnection con = conectarBD();
                OdbcCommand cmd = new OdbcCommand("select costo from productos order by idProducto", con);
                OdbcDataReader rd = cmd.ExecuteReader();
                rd.Read();
                if (rd.HasRows){ //Con esto estamos jalando los precios de los productos de la base de datos
                    precioVerde = rd.GetInt32(0);
                    lbVerdePrecio.Text = "$" + precioVerde;
                    rd.Read();
                    precioRojo = rd.GetInt32(0);
                    lbRojoPrecio.Text = "$" + precioRojo;
                    rd.Read();
                    precioMole = rd.GetInt32(0);
                    lbMolePrecio.Text = "$" + precioMole;
                    rd.Read();
                    precioDulce = rd.GetInt32(0);
                    lbDulcePrecio.Text = "$" + precioDulce;
                    rd.Read();
                    precioArroz = rd.GetInt32(0);
                    lbAtoleArrozPrecio.Text = "$" + precioArroz;
                    rd.Read();
                    precioVainilla = rd.GetInt32(0);
                    lbAtoleVainillaPrecio.Text = "$" + precioVainilla;
                    rd.Read();
                    precioFresa = rd.GetInt32(0);
                    lbAtoleFresaPrecio.Text = "$" + precioFresa;
                    rd.Read();
                    precioChocolate = rd.GetInt32(0);
                    lbAtoleChocolatePrecio.Text = "$" + precioChocolate;
                }
                rd.Close();
                con.Close();
            }
            catch(Exception ex)
            {
                String respuesta = "Error" + ex;
                Response.Write(respuesta);
            }
            
        }

       
        //BOTÓN DEL CARRITO
        protected void btCarrito_Click(object sender, EventArgs e) 
        {
            try
            {
                total = 0;
                carrito.Clear();
                /* Si el Drop Down List tiene un valor distinto de cero toma ese valor
                 *y lo agrega a su cantidadSeleccionada correspondiente; es análogo con todos
                * los productos.
                */
                    cantSeleccionada["verde"] = int.Parse(ddVerde.SelectedValue.ToString());
                    if (cantSeleccionada["verde"] != 0)
                    {
                        subTotal = cantSeleccionada["verde"] * precioVerde;
                        ObjSelec ob = new ObjSelec();
                        ob.producto = "verde";
                        ob.cantidad = cantSeleccionada["verde"];
                        ob.costo = subTotal;
                        carrito.Add(ob);
                        total = total + subTotal;
                        subTotal = 0;
                    }
                    cantSeleccionada["rojo"] = int.Parse(ddRojo.SelectedValue.ToString());
                    if(cantSeleccionada["rojo"] != 0)
                    {
                        subTotal = cantSeleccionada["rojo"] * precioRojo;
                        ObjSelec ob = new ObjSelec();
                        ob.producto = "rojo";
                        ob.cantidad = cantSeleccionada["rojo"];
                        ob.costo = subTotal;
                        carrito.Add(ob);
                        total = total + subTotal;
                        subTotal = 0;
                    }
                
                    cantSeleccionada["mole"] = int.Parse(ddMole.SelectedValue.ToString());
                    if (cantSeleccionada["mole"] != 0)
                    {
                        subTotal = cantSeleccionada["mole"] * precioMole;
                        ObjSelec ob = new ObjSelec();
                        ob.producto = "mole";
                        ob.cantidad = cantSeleccionada["mole"];
                        ob.costo = subTotal;
                        carrito.Add(ob);
                        total = total + subTotal;
                        subTotal = 0;
                    }
                
                    cantSeleccionada["dulce"] = int.Parse(ddDulce.SelectedValue.ToString());
                    if (cantSeleccionada["dulce"] != 0)
                    {
                        subTotal = cantSeleccionada["dulce"] * precioDulce;
                        ObjSelec ob = new ObjSelec();
                        ob.producto = "dulce";
                        ob.cantidad = cantSeleccionada["dulce"];
                        ob.costo = subTotal;
                        carrito.Add(ob);
                        total = total + subTotal;
                        subTotal = 0;
                    }
                
                    cantSeleccionada["arroz"] = int.Parse(ddAtoleArroz.SelectedValue.ToString());
                    if (cantSeleccionada["arroz"] != 0)
                    {
                        subTotal = cantSeleccionada["arroz"] * precioArroz;
                        ObjSelec ob = new ObjSelec();
                        ob.producto = "arroz";
                        ob.cantidad = cantSeleccionada["arroz"];
                        ob.costo = subTotal;
                        carrito.Add(ob);
                        total = total + subTotal;
                        subTotal = 0;
                    }
                
                    cantSeleccionada["vainilla"] = int.Parse(ddAtoleVainilla.SelectedValue.ToString());
                    if (cantSeleccionada["vainilla"] != 0)
                    {
                        subTotal = cantSeleccionada["vainilla"] * precioVainilla;
                        ObjSelec ob = new ObjSelec();
                        ob.producto = "vainilla";
                        ob.cantidad = cantSeleccionada["vainilla"];
                        ob.costo = subTotal;
                        carrito.Add(ob);
                        total = total + subTotal;
                        subTotal = 0;
                    }
                
                    cantSeleccionada["fresa"] = int.Parse(ddAtoleFresa.SelectedValue.ToString());
                    if (cantSeleccionada["fresa"] != 0)
                    {
                        subTotal = cantSeleccionada["fresa"] * precioFresa;
                        ObjSelec ob = new ObjSelec();
                        ob.producto = "fresa";
                        ob.cantidad = cantSeleccionada["fresa"];
                        ob.costo = subTotal;
                        carrito.Add(ob);
                        total = total + subTotal;
                        subTotal = 0;
                    }
                
                    cantSeleccionada["chocolate"] = int.Parse(ddChocolate.SelectedValue.ToString());
                    if (cantSeleccionada["chocolate"] != 0)
                    {
                        subTotal = cantSeleccionada["chocolate"] * precioChocolate;
                        ObjSelec ob = new ObjSelec();
                        ob.producto = "chocolate";
                        ob.cantidad = cantSeleccionada["chocolate"];
                        ob.costo = subTotal;
                        carrito.Add(ob);
                        total = total + subTotal;
                        subTotal = 0;
                    }
                gvOrden.DataSource = carrito; //Aquí llenamos el grid view donde se presentará un resumen de la orden del cliente para que este pueda verificarla
                gvOrden.DataBind();
                lbTotal.Text = "$ " + total;
                Session["carrito"] = carrito;
            }
            catch(Exception ex) {
                String respuesta = "Error" + ex;
                Response.Write(respuesta);
            }
        }

        protected void btConfirmarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                List<ObjSelec> carritoAUX = (List<ObjSelec>)Session["carrito"];
                int usuario = int.Parse(Session["usuario"].ToString());
                OdbcConnection con = conectarBD();
                OdbcCommand cmd = new OdbcCommand(String.Format("insert into pedidos(idCliente) values({0})", usuario), con);
                //CP
                if (cmd.ExecuteNonQuery() > -1)
                {
                    OdbcCommand cmd2 = new OdbcCommand("SELECT TOP 1 idPedido FROM pedidos ORDER BY idPedido DESC", con);
                    OdbcDataReader rd = cmd2.ExecuteReader();
                    int idPed = -1; //Se empieza en menos uno, para que en el caso de no haber podido sustraer la información necesaria de la BD el idPedido se quede en menos 1
                    if (rd.HasRows)
                    {
                        rd.Read();
                        idPed = rd.GetInt32(0);
                        rd.Close();
                    }
                        
                     //for each carrito
                     OdbcCommand cmd3, cmd4;
                     OdbcDataReader rd3;
                     int idProd = -1;
                     for (int i=0; i<carritoAUX.Count(); i++)
                     {
                        cmd3 = new OdbcCommand(String.Format("SELECT idProducto FROM productos WHERE nombre='{0}'", carritoAUX[i].producto), con);
                        rd3 = cmd3.ExecuteReader();
                        rd3.Read();
                        idProd = rd3.GetInt32(0);
                        rd3.Close();
                        cmd4 = new OdbcCommand(String.Format("INSERT INTO pedidosProductos(idPedido, idProducto, cantidad) values({0}, {1}, {2})", idPed, idProd, carritoAUX[i].cantidad), con);
                        cmd4.ExecuteNonQuery(); //Se registra el pedido en la base de datos
                     }
                }
                con.Close();
                Response.Redirect("Agradecimiento.aspx");
            }
            catch (Exception ex) {
                String respuesta = "Error" + ex;
                Response.Write(respuesta);
            }
        }
    }



    //CLASE AUXILIAR PARA CREAR LA LISTA DE PRODUCTOS TEMPORAL QUE PROBABLEMENTE SERÁ COMPRADA:
    public class ObjSelec
    {
        public String producto { get; set; }
        public int cantidad { get; set; }
        public int costo { get; set; }
    }

}