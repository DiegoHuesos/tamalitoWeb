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
        protected OdbcConnection conectarBD() {
            String stringConexion = "Driver={SQL Server Native Client 11.0};Server=localhost;Uid=sa;Pwd=sqladmin;Database=tamalito";
            try {
                OdbcConnection conexion = new OdbcConnection(stringConexion);
                conexion.Open();
                return conexion;
            } catch (Exception ex) {
                return null;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Algo(object sender, EventArgs e)
        {
            Console.WriteLine("le picastess");
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            submit.Text=  username.ToString();
        }
    }
}