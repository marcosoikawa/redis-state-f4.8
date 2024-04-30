using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace redis01
{
    public partial class About : Page
    {
        public void LoadCache()
        {
            //Laod Cache
            Session["FirstName"] = "Marcos";
            Session["LastName"] = "Oikawa";

            JavaScriptSerializer ser = new JavaScriptSerializer();

            Session["Produto"] = ser.Serialize(new Produto() { ID = 1, Category = new Category() { ID = 1, descricao = "montain bike" }, CategoryID = 1, Name = "Bike", Price = 200 });

            Produto prod = new Produto();
            prod = ser.Deserialize<Produto>((string)Session["Produto"]);
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCache();
            //if (!String.IsNullOrEmpty(Convert.ToString(Session["Produto"]))) {
            //    lblHit.InnerText = "Hit!";
            //}
            //else
            //{
            //    lblHit.InnerText = "Not Hit";
            //}

        }
    }
}