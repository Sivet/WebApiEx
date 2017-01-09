using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiExercise.Models
{
    public class Conversion
    {
        public string isoFrom { get; private set; }
        public string isoTo { get; private set; }
        public double amountFrom { get; private set; }
        public double amountTo { get; private set; }

        public Conversion(string isoFrom, string isoTo, double amountFrom, double amountTo)
        {
            this.isoFrom = isoFrom;
            this.isoTo = isoTo;
            this.amountFrom = amountFrom;
            this.amountTo = amountTo;
        }
    }
}