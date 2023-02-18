using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace API_View
{
    internal class AppDetails
    {
        public string ConsumedQuantity { get; set; }
        public double Cost { get; set; }   
        public string Date { get; set; }   
        public string InstanceId { get; set; }
        public string MeterCategory { get; set; }
        public string ResourceGroup { get; set; }
        public string ResourceLocation { get; set; }
        public string UnitOfMeasure { get; set; }
        public string Location { get; set; }
        public string ServiceName { get; set; }
    }
}
