using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TpsWebApi.Models
{
    public static class DAL
    {
        public static List<Purchase> GetAllPurchases()
        {
            return new List<Purchase> { 
                new Purchase(){ ItemNo = 1, Amount = 5, PurchaseDate = Convert.ToDateTime("01/02/2020") },
                new Purchase(){ ItemNo = 2, Amount = 7, PurchaseDate = Convert.ToDateTime("03/03/2020") },
                new Purchase(){ ItemNo = 3, Amount = 8, PurchaseDate = Convert.ToDateTime("04/07/2020") },
                new Purchase(){ ItemNo = 4, Amount = 9, PurchaseDate = Convert.ToDateTime("06/08/2020") },
                new Purchase(){ ItemNo = 5, Amount = 10, PurchaseDate = Convert.ToDateTime("07/09/2020") },
                new Purchase(){ ItemNo = 6, Amount = 15, PurchaseDate = Convert.ToDateTime("08/12/2020") }
            };
        }
    }
}