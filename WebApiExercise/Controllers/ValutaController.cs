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
        private List<Models.Conversion> conversionList;
        [HttpGet]
        public double ConvertCurrency(double amount, string isoFrom, string isoTo)
        {
            double result = new Models.Calculator().ConvertCurrency(amount, isoFrom, isoTo);
            
            return result;
        }
        [HttpGet]
        [ActionName("CurrencyListe")]
        public List<Models.Currency> GetCurrencyList()
        {
            return new Models.CurrencyMaker().GetList();
        }
        
        [HttpPut]
        public void ChangeExchangeRate(string name, string iso, double exchangerate)
        {
            new Models.CurrencyMaker().ChangeExchangeRate(name, iso, exchangerate);
        }
        [HttpDelete]
        public void DeleteExchangeRate(string iso)
        {
            new Models.CurrencyMaker().DeleteExchangeRate(iso);
        }

    }
}
