using csharp_lista_indirizzi;
using System;
using System.Net;

List<Address> addresses = new List<Address>();


try
{
    StreamReader file = File.OpenText("C:\\Users\\Aurora\\source\\repos\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\addresses.csv");
    int lineCount = 0;

    while (!file.EndOfStream)
    {
        string textRow = file.ReadLine();
        lineCount++;

        if (lineCount > 1)
        {
            string[] separatedLine = textRow.Split(',');

            if (separatedLine.Length != 6)
            {
                Console.WriteLine("La riga " + lineCount + " non rispetta lo standard degli indirizzi");
            }
            else
            {
                int zipAddressRead = int.Parse(separatedLine[5]);
                Address AddressRead = new Address(separatedLine[0], separatedLine[1], separatedLine[2], separatedLine[3], separatedLine[4], zipAddressRead);
                addresses.Add(AddressRead);
                Console.WriteLine(AddressRead.ToString());
            }
        }
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
foreach (Address address in addresses)
{
    Console.WriteLine(address);
}