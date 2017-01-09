using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiExercise.Controllers
{
    public class ValutaController : ApiController
    {
        //Models.RepoConversions ConRepo = new Models.RepoConversions();
        [HttpGet]
        public double ConvertCurrency(double amount, string isoFrom, string isoTo)
        {
            return new Models.Calculator().ConvertCurrency(amount, isoFrom, isoTo);
        }
        [HttpGet]
        public List<Models.Currency> GetList()
        {
            return new Models.CurrencyMaker().GetList();
        }
       
    }
}
