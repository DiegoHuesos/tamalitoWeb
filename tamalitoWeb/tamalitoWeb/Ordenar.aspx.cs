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

        protected void btVerde_Click(object sender, ImageClickEventArgs e)
        {
            if (!botonesActivos["verde"])
            {
                botonesActivos["verde"] = true;

            }
            else
            {
                botonesActivos["verde"] = false;

            }
            actualizaLista();
        }

        public void actualizaLista()
        {
            gvOrden.DataSource = null;
            carrito.Clear();
            total = 0;
            foreach (var item in botonesActivos)
            {
                if (item.Value)
                {
                    if ((item.Key).Equals("verde") || (item.Key).Equals("rojo") || (item.Key).Equals("mole") || (item.Key).Equals("dulce"))
                        subTotal = cantSeleccionada[item.Key] * precioTamal;
                    else
                        subTotal = cantSeleccionada[item.Key] * precioAtole;

                    ObjSelec ob = new ObjSelec();
                    ob.producto = (item.Key).ToString();
                    ob.cantidad = cantSeleccionada[item.Key];
                    ob.costo = subTotal;
                    carrito.Add(ob);

                    total += subTotal;
                }
            }
            gvOrden.DataSource = carrito;
            gvOrden.DataBind();
            lbTotal.Text = "$ " + total;
        }

        

        protected void ddVerde_TextChanged(object sender, EventArgs e)
        {
            //lbTotal.Text = ""+ ddVerde.SelectedValue.ToString();
            
            cantSeleccionada["verde"] = int.Parse(ddVerde.SelectedValue.ToString());
            actualizaLista();
            
        }

        protected void ddVerde_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTotal.Text = "bbb";
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