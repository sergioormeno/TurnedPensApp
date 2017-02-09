using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoligrafosTorneadosApp.Models
{
    public class Products
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int stock { get; set; }
        public int value { get; set; }
        public string weight { get; set; }
        public string size { get; set; }
        public string description { get; set; }
    }
}
