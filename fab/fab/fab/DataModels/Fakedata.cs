using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace fab.DataModels
{

    public class Fakedata
    {
        [JsonProperty(PropertyName = "Id")]
        public string ID { get; set; }

        [JsonProperty(PropertyName = "menuNo")]
        public string MenuID { get; set; }

        [JsonProperty(PropertyName = "itemName")]
        public string ItemName { get; set; }

        [JsonProperty(PropertyName = "desc")]
        public string MenuDesc { get; set; }

        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        [JsonProperty(PropertyName = "price")]
        public string Price { get; set; }

        [JsonProperty(PropertyName = "promo")]
        public string Promo { get; set; }

        [JsonProperty(PropertyName = "promodisc")]
        public string PromoDiscount { get; set; }

        [JsonProperty(PropertyName = "orderno")]
        public string OrderNo { get; set; }

        [JsonProperty(PropertyName = "customerName")]
        public string CustomerName { get; set; }

        [JsonProperty(PropertyName = "imagef")]
        public string ImageF { get; set; }
}

    }

