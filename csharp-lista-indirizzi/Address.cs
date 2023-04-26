using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
            if (name == "")
            {
                throw new ArgumentException("Valore non valido..");
            }
            this.surname = surname;
            if (surname == "")
            {
                throw new ArgumentException("Valore non valido..");
            }
            this.street = street;
            if (street == "")
            {
                throw new ArgumentException("Valore non valido..");
            }
            this.city = city;
            if (city == "")
            {
                throw new ArgumentException("Valore non valido..");
            }
            this.province = province;
            if (province == "")
            {
                throw new ArgumentException("Valore non valido..");
            }
            this.zip = zip;
            if (zip > 5)
            {
                throw new ArgumentException("Valore non valido..");
            }
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
