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
        [HttpPut]
        public void ChangeExchangeRate(string name, string iso, double exchangerate)
        {
            new Models.CurrencyMaker().ChangeExchangeRate(name, iso, exchangerate);
        }

    }
}
