using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiExercise.Models
{
    public class Calculator
    {
        Models.CurrencyMaker maker = new Models.CurrencyMaker();
        public double ConvertCurrency(double amount, string isoFrom, string isoTo)
        {
            double result;

            double exchangeFrom = maker.FindCurrency(isoFrom).exchangeRate; //finder exhange raten for der man kommer fra
            double exchangeTo = maker.FindCurrency(isoTo).exchangeRate; //finder exchange raten for der man vil til

            exchangeFrom = (exchangeFrom / 100) * amount; //Omregner til danske, da vi kun kender exchange rates i forhold til danske
            result = exchangeFrom / (exchangeTo / 100); //Regner fra danske til den valuta man ønskede.

            //ConRepo.SaveConversion(new Conversion(isoFrom, isoTo, amount, result)); //Gemmer omregninger i conversion repositoriet
            return result;
        }
        
    }
}