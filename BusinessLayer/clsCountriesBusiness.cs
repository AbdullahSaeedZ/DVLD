using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsCountriesBusiness
    {

        public int CountryID { get; private set; }
        public string CountryName { get; set; }

        public clsCountriesBusiness()
        {
            this.CountryID = -1;
            this.CountryName = "";
        }

        clsCountriesBusiness(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }

        public static clsCountriesBusiness GetCountry(int CountryID)
        {
            string CountryName = "";
            if (clsCountriesDataAccess.GetCountry(CountryID, ref CountryName))
                return new clsCountriesBusiness(CountryID, CountryName);
            else
                return null;
            
        }

        public static clsCountriesBusiness GetCountry(string CountryName)
        {
            int CountryID = -1;
            if (clsCountriesDataAccess.GetCountry(ref CountryID, CountryName))
                return new clsCountriesBusiness(CountryID, CountryName);
            else
                return null;
        }

        public static DataTable GetAllCountries()
        {
            return clsCountriesDataAccess.GetAllCountries();
        }
        
        

    }
}
