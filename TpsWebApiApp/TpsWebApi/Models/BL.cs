using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TpsWebApi.Models
{
    public class BL
    {
        public List<Purchase> GetPurchasesByStartFromAndBulkSize(string startFrom, int bulkSize)
        {
            DateTime startFromDate;
            if (!DateTime.TryParse(startFrom, out startFromDate))
            {
                startFromDate = Convert.ToDateTime(startFrom);
            }
            else
            {
                startFromDate = DateTime.Now;
            }

            return DAL.GetAllPurchases()
                   .Where(x => DateTime.Compare(x.PurchaseDate, startFromDate) > 0)
                   .Take(bulkSize).ToList();
        }
    }
}