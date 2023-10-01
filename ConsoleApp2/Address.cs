using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Address
    {
        public string index;
        public string country;
        public string city;
        public string street;
        public string house;
        public string apartment;

        public string GetCountry() { return country; }
        public void SetCountry(string country) { this.country = country; }
        public string GetCity() { return city; }
        public void SetCity(string city) { this.city = city; }
        public string GetIndex() { return index; }
        public void SetIndex(string index) { this.index = index; }
        public string GetHouse() { return house; }
        public void SetHouse(string house) { this.house = house; }
        public string GetApartament() { return apartment; }
        public void SetApartament(string apartment) { this.apartment = apartment; }
        public override string ToString()
        {
            return $"{index},{country},{city},{street},{house},{apartment}";
        }

    }
}
    
