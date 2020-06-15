using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TpsWebApi.Models
{
    public class BL
    {
        public TpsResult GetPurchasesByStartFromAndBulkSize(string startFrom, int bulkSize)
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

            var purchases = DAL.GetAllPurchases()
                            .Where(x => DateTime.Compare(x.PurchaseDate, startFromDate) > 0)
                            .ToList();

            return new TpsResult()
            {
                Purchases = purchases.Take(bulkSize).ToList(),
                TotalPurchases = purchases.Count()
            };
        }
    }
}