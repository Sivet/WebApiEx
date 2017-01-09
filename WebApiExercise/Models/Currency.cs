using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiExercise.Models
{
    public class Currency
    {
        public string name { get; set; }
        public string iso { get; set; }
        public double exchangeRate { get; set; }

        public Currency(string name, string iso, double exchangeRate)
        {
            this.name = name;
            this.iso = iso;
            this.exchangeRate = exchangeRate;
        }
    }
}