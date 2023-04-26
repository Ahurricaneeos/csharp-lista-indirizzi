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
        int zip;

        public Address(string name, string surname, string street, string city, string province, int zip)
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
        public int GetZip() { return zip;}

        public override string ToString()
        {
            string rappStr = "------- Indirizzi: -------" + "\n";
            rappStr += "Nome: " + this.name + "\n";
            rappStr += "Cognome: " + this.surname + "\n";
            rappStr += "Via: " + this.street + "\n";
            rappStr += "Città: " + this.city + "\n";
            rappStr += "Provincia: " + this.province + "\n";
            rappStr += "Cap: " + this.zip + "\n";
            return rappStr;
        }
    }
}
