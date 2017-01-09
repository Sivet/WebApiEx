using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace WebApiExercise.Models
{
    public class CurrencyMaker
    {

        private List<Currency> CurrencyListe;
        private object obj = new object();

        public CurrencyMaker()
        {
            Monitor.Enter(obj);
            try
            {
                if (CurrencyListe == null)
                {
                    CurrencyListe = new List<Currency>();
                    FillList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Monitor.Exit(obj);
            }

        }

        public List<Currency> GetList()
        {
            Monitor.Enter(CurrencyListe);
            try
            {
                return CurrencyListe;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Monitor.Exit(CurrencyListe);
            }

        }

        private void MakeNewCurrency(string name, string iso, double exchangerate)
        {
            try
            {
                CurrencyListe.Add(new Currency(name, iso, exchangerate));
            }
            catch (Exception)
            {
                throw;
            }

        }
        public void ChangeExchangeRate(string name, string iso, double exchangerate)
        {
            bool exits = false;
            Monitor.Enter(CurrencyListe);
            try
            {
                foreach (Currency item in CurrencyListe)
                {
                    if (item.iso == iso)
                    {
                        exits = true;
                        item.name = name;
                        item.exchangeRate = exchangerate;
                    }
                }
                if (exits == false)
                {
                    MakeNewCurrency(name, iso, exchangerate);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Monitor.Exit(CurrencyListe);
            }

        }

        private void FillList()
        {
            //CurrencyListe.Add(new Currency("Danmark", "DAN", 100.0000));
            CurrencyListe.Add(new Currency("Amerika", "USD", 524.0200));
            CurrencyListe.Add(new Currency("Canada", "CAD", 492.2700));
            CurrencyListe.Add(new Currency("Euro", "EUR", 745.9900));
            CurrencyListe.Add(new Currency("Norge", "NOK", 90.3400));
            CurrencyListe.Add(new Currency("Storbritannien", "GBP", 947.5300));
            CurrencyListe.Add(new Currency("Sverige", "SEK", 78.2100));
        }
    }
}