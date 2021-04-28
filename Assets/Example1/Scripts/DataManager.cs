using System.Collections;
using System.Collections.Generic;
using Example1.Attributes;
using Example1.Models;
using UnityEngine;

namespace Example1
{
    public class DataManager
    {

        [Selectables]
        static public  List<City> GetCities()
        {
            List<City> cities = new List<City>();
            cities.Add(new City("SF", 0));
            cities.Add(new City("NY", 1));
            cities.Add(new City("London", 2));
            return cities;

        }
        [Selectables]
        static public List<Country> GetCountries()
        {
            List<Country> countries = new List<Country>();
            countries.Add(new Country("Ameriac", 0));
            countries.Add(new Country("France", 1));
            countries.Add(new Country("England", 2));
            return countries;
        }

        static public bool IsOk()
        {
            return true;
        }

    }
}
