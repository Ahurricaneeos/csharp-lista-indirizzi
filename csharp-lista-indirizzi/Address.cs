using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public class Address
    {
        string name;
        string surname;
        string street;
        string city;
        string province;
        string zip;

        public Address(string name, string surname, string street, string city, string province, string zip)
        {
            this.name = name;
            this.surname = surname;
            this.street = street;
            this.city = city;
            this.province = province;
            this.zip = zip;
        }

        public string GetName() { return name; }
        public string GetSurname() {  return surname; }
        public string GetStreet() { return street; }
        public string GetCity() { return city;}
        public string GetProvince() {  return province;}
        public string GetZip() { return zip;}


    }

     
}
