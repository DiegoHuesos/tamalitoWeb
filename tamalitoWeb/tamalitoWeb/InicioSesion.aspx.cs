using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;

namespace tamalitoWeb
{
    public partial class InicioSesion : System.Web.UI.Page
    {
        protected OdbcConnection conectarBD() { //Se crea el método para conectarse a la base de datos. Este está presente en todas las ventanas que lo necesitan.
            String stringConexion = "Driver={SQL Server Native Client 11.0};Server=localhost;Uid=sa;Pwd=sqladmin;Database=tamalito";
            try {
                OdbcConnection conexion = new OdbcConnection(stringConexion);
                conexion.Open();
                return conexion;
            } catch (Exception ex) {
                String respuesta = "Error" + ex;
                Response.Write(respuesta);
                return null;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["idRegistrado"] != null) //Devuelve el mensaje correspondiente en caso de que un nuevo usario se haya registrado. En la página de registro se puede ver más al respecto
                lbRegistroNuevo.Text = Session["idRegistrado"].ToString();
        }

        protected void Enviar_Click(object sender, EventArgs e) //Funcionalidad del botón
        {
            OdbcConnection con = conectarBD();
            try
            {
                int usuario = int.Parse(User.Text);
                String contra = Password.Text;
                String query = String.Format("select contra from clientes where idCliente={0}", usuario);
                OdbcCommand cmd = new OdbcCommand(query, con);
                OdbcDataReader rd = cmd.ExecuteReader();
                rd.Read();
                if (rd.HasRows)
                {
                    if (contra.Equals(rd.GetString(0))) //En caso de que usuario y contraseña estén correctos mandará al usuario a la página de Ordenar
                    {
                        Session["usuario"] = usuario;
                        Response.Redirect("Ordenar.aspx");
                    }
                    else
                    {
                        Session["usuario"] = "";
                        String respuesta = "Contraseña Incorrecta"; //Se muestra este mensaje cuando la constraseña está incorrecta y no te da acceso a la página de Ordenar
                        Response.Write(respuesta);
                    }
                }
                else
                {
                    String respuesta = "Usuario Inexistente"; //Muestra este mensaje en caso de que el "Username" proporcionado no se encuentre en la base de datos
                    Response.Write(respuesta);
                }
                rd.Close();
                con.Close();
            }
            catch(Exception ex)
            {
                String respuesta = "<script>alert('Error'" + ex + ");</script>";
                Response.Write(respuesta);
            }
        }
    }
}