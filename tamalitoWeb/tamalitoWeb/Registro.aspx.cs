using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tamalitoWeb
{
    public partial class Registro : System.Web.UI.Page
    {
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

        }

        protected void Enviar_Click(object sender, EventArgs e)
        {
            OdbcConnection con = conectarBD();
            try
            {
                String nombre = Nombre.Text;
                String apellidoP = ApellidoPaterno.Text;
                String apellidoM = ApellidoMaterno.Text;
                String correo = Correo.Text;
                String numeroTarjeta = numTarjeta.Text;
                String contra = contrasenia.Text;
                String query = String.Format("select correo from clientes where correo='{0}'", correo); //Busca si el correo ya está registrado
                OdbcCommand cmd = new OdbcCommand(query, con);
                OdbcDataReader rd = cmd.ExecuteReader();
                rd.Read();
                if (!rd.HasRows)//Si el correo no está registrado el query debería regresar vacío
                {
                    String query2 = String.Format("insert into clientes(numTarjeta, correo, nombre, apellidoP, apellidoM, contra) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", numeroTarjeta, correo, nombre, apellidoP, apellidoM, contra);
                    OdbcCommand cmd2 = new OdbcCommand(query2, con);
                    cmd2.ExecuteNonQuery();
                    String query3 = "select max(idCliente) from clientes";
                    OdbcCommand cmd3 = new OdbcCommand(query3, con);
                    OdbcDataReader rd2 = cmd3.ExecuteReader();
                    rd2.Read();
                    Session["idRegistrado"] = "Tu Número de Usuario:" + rd2.GetInt32(0);
                    Session["usuario"]=rd.GetInt32(0);
                    String respuesta = "Bienvenido";
                    Response.Write(respuesta);
                    rd2.Close();
                }
                else
                {
                    Session["idRegistrado"] = "Correo ya registrado";
                }
                rd.Close();
                con.Close();
                
            }
            catch (Exception ex)
            {
                String respuesta = "<script>alert('Error'" + ex + ");</script>";
                Response.Write(respuesta);
            }
            
            Response.Redirect("InicioSesion.aspx");
        }
    }
}