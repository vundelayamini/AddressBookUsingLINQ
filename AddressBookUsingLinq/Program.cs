using System;
using System.Data;

namespace AddressBookUsingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to AddressBook Using Linq");
            AddressBookDataTable addressBookDataTable = new AddressBookDataTable();
            DataTable table = addressBookDataTable.CreateAddressBookDataTable();
            addressBookDataTable.DisplayContacts(table);
            //addressBookDataTable.EditContact(table);
            //addressBookDataTable.DeleteContact(table);
            Console.WriteLine("\n");
            //addressBookDataTable.RetrieveContactBelongingToPerticularCityORState(table);
            //addressBookDataTable.CountContactsFromPerticularCityANDState(table);
            //addressBookDataTable.SortContacts(table);

        }
    }
}
