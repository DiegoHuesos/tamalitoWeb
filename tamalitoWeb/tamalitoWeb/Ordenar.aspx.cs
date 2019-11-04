using System;
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
        int precioTamal = 20;
        int precioAtole = 10;
        int subTotal = 0;
        int total = 0;

        //DICCIONARIOS PARA SABER SI LOS BOTONES SE ENCUNETRAN ACTIVOS:
        Dictionary<String, Boolean> botonesActivos = new Dictionary<String, Boolean>()
        {
            ["verde"] = false,
            ["rojo"] = false,
            ["mole"] = false,
            ["dulce"] = false,
            ["arroz"] = false,
            ["vainilla"] = false,
            ["fresa"] = false,
            ["chocolate"] = false
        };
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
                if (!IsPostBack)
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
                        subTotal = cantSeleccionada["verde"] * precioTamal;
                        ObjSelec ob = new ObjSelec();
                        ob.producto = "Tamal Verde";
                        ob.cantidad = cantSeleccionada["verde"];
                        ob.costo = subTotal;
                        carrito.Add(ob);
                        total = total + subTotal;
                        subTotal = 0;
                    }
                    cantSeleccionada["rojo"] = int.Parse(ddRojo.SelectedValue.ToString());
                    if(cantSeleccionada["rojo"] != 0)
                    {
                        subTotal = cantSeleccionada["rojo"] * precioTamal;
                        ObjSelec ob = new ObjSelec();
                        ob.producto = "Tamal Rojo";
                        ob.cantidad = cantSeleccionada["rojo"];
                        ob.costo = subTotal;
                        carrito.Add(ob);
                        total = total + subTotal;
                        subTotal = 0;
                    }
                
                    cantSeleccionada["mole"] = int.Parse(ddMole.SelectedValue.ToString());
                    if (cantSeleccionada["mole"] != 0)
                    {
                        subTotal = cantSeleccionada["mole"] * precioTamal;
                        ObjSelec ob = new ObjSelec();
                        ob.producto = "Tamal Mole";
                        ob.cantidad = cantSeleccionada["mole"];
                        ob.costo = subTotal;
                        carrito.Add(ob);
                        total = total + subTotal;
                        subTotal = 0;
                    }
                
                    cantSeleccionada["dulce"] = int.Parse(ddDulce.SelectedValue.ToString());
                    if (cantSeleccionada["dulce"] != 0)
                    {
                        subTotal = cantSeleccionada["dulce"] * precioTamal;
                        ObjSelec ob = new ObjSelec();
                        ob.producto = "Tamal Dulce";
                        ob.cantidad = cantSeleccionada["dulce"];
                        ob.costo = subTotal;
                        carrito.Add(ob);
                        total = total + subTotal;
                        subTotal = 0;
                    }
                
                    cantSeleccionada["arroz"] = int.Parse(ddAtoleArroz.SelectedValue.ToString());
                    if (cantSeleccionada["arroz"] != 0)
                    {
                        subTotal = cantSeleccionada["arroz"] * precioAtole;
                        ObjSelec ob = new ObjSelec();
                        ob.producto = "Atole Arroz";
                        ob.cantidad = cantSeleccionada["arroz"];
                        ob.costo = subTotal;
                        carrito.Add(ob);
                        total = total + subTotal;
                        subTotal = 0;
                    }
                
                    cantSeleccionada["vainilla"] = int.Parse(ddAtoleVainilla.SelectedValue.ToString());
                    if (cantSeleccionada["vainilla"] != 0)
                    {
                        subTotal = cantSeleccionada["vainilla"] * precioAtole;
                        ObjSelec ob = new ObjSelec();
                        ob.producto = "Atole Vainilla";
                        ob.cantidad = cantSeleccionada["vainilla"];
                        ob.costo = subTotal;
                        carrito.Add(ob);
                        total = total + subTotal;
                        subTotal = 0;
                    }
                
                    cantSeleccionada["fresa"] = int.Parse(ddAtoleFresa.SelectedValue.ToString());
                    if (cantSeleccionada["fresa"] != 0)
                    {
                        subTotal = cantSeleccionada["fresa"] * precioAtole;
                        ObjSelec ob = new ObjSelec();
                        ob.producto = "Atole Fresa";
                        ob.cantidad = cantSeleccionada["fresa"];
                        ob.costo = subTotal;
                        carrito.Add(ob);
                        total = total + subTotal;
                        subTotal = 0;
                    }
                
                    cantSeleccionada["chocolate"] = int.Parse(ddChocolate.SelectedValue.ToString());
                    if (cantSeleccionada["chocolate"] != 0)
                    {
                        subTotal = cantSeleccionada["chocolate"] * precioAtole;
                        ObjSelec ob = new ObjSelec();
                        ob.producto = "Atole Chocolate";
                        ob.cantidad = cantSeleccionada["chocolate"];
                        ob.costo = subTotal;
                        carrito.Add(ob);
                        total = total + subTotal;
                        subTotal = 0;
                    }
                
                gvOrden.DataSource = carrito;
                gvOrden.DataBind();
                lbTotal.Text = "$ " + total;
                
            }
            catch(Exception ex) {
                String respuesta = "Error" + ex;
                Response.Write(respuesta);
            }
        }

        protected void btGenerarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                Session["total"] = "aaa"; //total;
                //Session["carrito"] = carrito;
                Response.Redirect("ConfirmarCompra.aspx");
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