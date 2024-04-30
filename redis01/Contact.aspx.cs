using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace redis01
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(Convert.ToString(Session["Produto"])))
            {
                JavaScriptSerializer ser = new JavaScriptSerializer();
                Produto prod = new Produto();
                prod = ser.Deserialize<Produto>((string)Session["Produto"]);
                lblHit.InnerText = "Hit!";
                lblPrice.InnerText = Convert.ToString(prod.Price);
            }
            else
            {
                lblHit.InnerText = "Not Hit";
            }
        }       

        protected void btnModifyCache_Click(object sender, EventArgs e)
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();
            Produto prod = new Produto();
            prod = ser.Deserialize<Produto>((string)Session["Produto"]);
            prod.Price = prod.Price + 100;
            Session["Produto"] = ser.Serialize(prod);
        }
    }
}