using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TpsWebApi.Models;

namespace TpsWebApi.Controllers
{
    public class TpsController : ApiController
    {
        // GET api/tps
        public List<Purchase> Get(string startFrom, int bulkSize)
        {
            var businessLogic = new BL();

            return businessLogic.GetPurchasesByStartFromAndBulkSize(startFrom, bulkSize);
        }
    }
}
