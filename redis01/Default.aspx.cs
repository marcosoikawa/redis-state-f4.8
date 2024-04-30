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
    public partial class _Default : Page
    {
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
    public class Produto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }

    }

    public class Category
    {
        public int ID { get; set; }
        public string descricao { get; set; }

    }


}