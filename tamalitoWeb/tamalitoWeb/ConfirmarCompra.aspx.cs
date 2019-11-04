using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tamalitoWeb
{
    public partial class ConfirmarCompra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //gvOrden.DataSource = Session["carrito"];
            //gvOrden.DataBind();
       
            lbTotal.Text = "$ " + Session["total"].ToString(); 
        }

        protected void btConfirmarPedido_Click(object sender, EventArgs e)
        {

        }
    }
}