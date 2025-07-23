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
    /// <summary>
    /// Contact page that demonstrates verifying and modifying cached data
    /// </summary>
    public partial class Contact : Page
    {
        /// <summary>
        /// Handles the Page_Load event, verifies cache hit and displays product information
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The event data</param>
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

        /// <summary>
        /// Handles the modify cache button click event to increase product price by $100
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The event data</param>
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