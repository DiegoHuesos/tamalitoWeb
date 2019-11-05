using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tamalitoWeb
{
    public partial class LogOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["usuario"] = null;
            Session["carrito"] = null;
            Session["idRegistrado"]=null;
            Response.Redirect("index.aspx");
        }
    }
}