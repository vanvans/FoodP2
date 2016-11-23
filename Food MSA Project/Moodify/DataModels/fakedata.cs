using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Moodify.DataModels
{
    public class Fakedata
    {
        [JsonProperty(PropertyName="MenuID")]
        public string MenuID { get; set; }

        [JsonProperty(PropertyName = "itemName")]
        public string ItemName { get; set; }

        [JsonProperty(PropertyName = "MenuDesc")]
        public string MenuDesc { get; set; }

        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        [JsonProperty(PropertyName = "price")]
        public string Price { get; set; }

        [JsonProperty(PropertyName = "promo")]
        public string Promo { get; set; }

        [JsonProperty(PropertyName = "promoDisc")]
        public string PromoDiscount { get; set; }

        [JsonProperty(PropertyName = "orderNo")]
        public string OrderNo { get; set; }

        [JsonProperty(PropertyName = "custName")]
        public string CustomerName { get; set; }

        [JsonProperty(PropertyName = "imagef")]
        public string ImageF { get; set; }

        [JsonProperty(PropertyName = "deleted")]
        public bool deleted { get; set; }
   
    }

}
