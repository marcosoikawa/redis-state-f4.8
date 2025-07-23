using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;
using Newtonsoft.Json;
using System.Text;
using Microsoft.Web.Redis;
using StackExchange.Redis;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Script.Serialization;
using static redis01._Default;
using RestSharp.Serializers;

namespace redis01
{
    /// <summary>
    /// Default page for the Redis state demonstration application
    /// </summary>
    public partial class _Default : Page
    {
        /// <summary>
        /// Handles the Page_Load event for the default page
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The event data</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        //public class JsonSerializer : ISerializer
        //{
        //    private static JsonSerializerSettings _settings = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };

        //    public byte[] Serialize(object data)
        //    {
        //        return Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data, _settings));
        //    }

        //    public object Deserialize(byte[] data)
        //    {
        //        if (data == null)
        //        {
        //            return null;
        //        }
        //        return JsonConvert.DeserializeObject(Encoding.UTF8.GetString(data), _settings);
        //    }
        //}

            }
    /// <summary>
    /// Represents a product in the application with its associated properties
    /// </summary>
    public class Produto
    {
        /// <summary>
        /// Gets or sets the unique identifier for the product
        /// </summary>
        public int ID { get; set; }
        
        /// <summary>
        /// Gets or sets the name of the product
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Gets or sets the category identifier for the product
        /// </summary>
        public int CategoryID { get; set; }
        
        /// <summary>
        /// Gets or sets the category object associated with the product
        /// </summary>
        public Category Category { get; set; }
        
        /// <summary>
        /// Gets or sets the price of the product
        /// </summary>
        public decimal Price { get; set; }

    }

    /// <summary>
    /// Represents a product category with its properties
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Gets or sets the unique identifier for the category
        /// </summary>
        public int ID { get; set; }
        
        /// <summary>
        /// Gets or sets the description of the category
        /// </summary>
        public string descricao { get; set; }

    }


}