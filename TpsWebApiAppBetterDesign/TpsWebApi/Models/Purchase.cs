using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TpsWebApi.Models
{
    public class Purchase
    {
        public int ItemNo { get; set; }
        public int Amount { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}