using System;
using System.Collections.Generic;
using System.Linq;
//using System.ServiceModel.Activation;
using System.Web;

namespace WebApiExercise.Models
{
    //påkrævet for at kunne arbejde med HttpContext aka Cockies og sessions.
    //[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class RepoConversions
    {
        private List<Conversion> conversionList;
        public RepoConversions()
        {
            if ((List<Conversion>)HttpContext.Current.Session["conversionList"] != null)
            {
                conversionList = (List<Conversion>)HttpContext.Current.Session["conversionList"];
            }
            if (conversionList == null)
            {
                conversionList = new List<Conversion>();
            }
            HttpContext.Current.Session["conversionList"] = conversionList;
        }
        public void SaveConversion(Conversion conversion)
        {
            conversionList.Add(conversion);
        }
        public List<Conversion> GetConversionList()
        {
            return conversionList;
        }
    }
}