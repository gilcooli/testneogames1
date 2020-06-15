using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TpsWebApi.Models
{
    public class TpsResult
    {
        public List<Purchase> Purchases { get; set; }
        public int TotalPurchases { get; set; }
    }
}