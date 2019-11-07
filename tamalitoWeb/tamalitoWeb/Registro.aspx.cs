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
                    cmd2.ExecuteNonQuery(); //Se da de alta al nuevo cliente en la base de datos 
                    String query3 = "select max(idCliente) from clientes";
                    OdbcCommand cmd3 = new OdbcCommand(query3, con);
                    OdbcDataReader rd2 = cmd3.ExecuteReader();
                    rd2.Read();
                    Session["idRegistrado"] = "Tu Número de Usuario:" + rd2.GetInt32(0); //Se le mostrará su respectivo número de cliente al mismo; este será su "Username" al momento de ingresar a su cuenta de Tamalito
                    Session["usuario"]=rd.GetInt32(0);
                    String respuesta = "Bienvenido";
                    Response.Write(respuesta);
                    rd2.Close();
                }
                else
                {
                    Session["idRegistrado"] = "Correo ya registrado"; //En caso de que el correo proporcioado ya esté registrado en la base de datos, este mensaje se le mostrará al nuevo cliente
                }
                rd.Close();
                con.Close();
                
            }
            catch (Exception ex)
            {
                String respuesta = "<script>alert('Error'" + ex + ");</script>";
                Response.Write(respuesta);
            }
            
            Response.Redirect("InicioSesion.aspx"); //Una vez que se registra se manda al nuevo cliente a la ventana de Incio de Sesión para que inicie sesión con su número de cliente asignado o para ver el mensaje de que debe volver a registrarse con un correo distinto dependiendo del caso.
        }
    }
}