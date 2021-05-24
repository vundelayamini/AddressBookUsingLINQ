using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;


namespace AddressBookUsingLinq
{
    class AddressBookDataTable
    {
        public DataTable CreateAddressBookDataTable()
        {
            DataTable addressBookDataTable = new DataTable();
            //Add Columns to DataTable
            addressBookTable.Columns.Add("FirstName", typeof(string));
            addressBookTable.Columns.Add("LastName", typeof(string));
            addressBookTable.Columns.Add("Address", typeof(string));
            addressBookTable.Columns.Add("City", typeof(string));
            addressBookTable.Columns.Add("State", typeof(string));
            addressBookTable.Columns.Add("Zip", typeof(int));
            addressBookTable.Columns.Add("PhoneNumber", typeof(long));
            addressBookTable.Columns.Add("Email", typeof(string));

            //Add Values for Columns
            addressBookDataTable.Rows.Add("Yamini", "Lakshmi", "Mahadevpura", "Banglore", "KA", 673262, 8979325434, "Yamini@gmail.com");
            addressBookDataTable.Rows.Add("Mahi", "Lakshmi", "Highway", "Pune", "MH", 7663526, 833343210, "mahi@gmail.com");
            addressBookDataTable.Rows.Add("Jhanu", "Radha", "Flex Road", "Mumbai", "MH", 303222, 6876543210, "jhanu@gmail.com");
            addressBookDataTable.Rows.Add("Gayi", "Pavithra", " Near Road", "Benglore", "Karnataka", 400028, 889000880, "gayi@gmail.com");
            addressBookDataTable.Rows.Add("Krishna", "Siri", "Chennai Highway", "chennai", "Tamilnadu", 323254, 8877743210, "krishna@gmail.com");
            addressBookDataTable.Rows.Add("Hanshi", "Mahi", "Highway Road", "Hyderabad", "Telangana", 485254, 7877743990, "hanshi@gmail.com");
            addressBookDataTable.Rows.Add("Pavani", "raju", "Baroda", "Baroda", "MP", 43254, 7888743210, "pavani@gmail.com");


            return addressBookDataTable;
        }
        /// <summary>
        ///Display the Data table Contacts
        /// </summary>
        /// <param name="table"></param>
        public void DisplayContacts(DataTable table)
        {
            var contacts = table.Rows.Cast<DataRow>();
            foreach (var contact in contacts)
            {
                Console.WriteLine("\n------------------------------------");
                Console.Write("\nFirst Name : " + contact.Field<string>(0) + " " + "\nLast Name : " + contact.Field<string>("LastName") + " " + "\nAddress : " + contact.Field<string>("Address") + " " + "\nCity : " + contact.Field<string>("City") + " " + "\nState : " + contact.Field<string>("State")
                    + " " + "\nZip : " + contact.Field<int>("Zip") + " " + "\nPhone Number : " + contact.Field<long>("PhoneNumber") + " " + "\nEmail : " + contact.Field<string>("Email") + " ");
                Console.WriteLine("\n------------------------------------");
            }
        }
        /// <summary>
        /// Edit the Contact
        /// </summary>
        /// <param name="table"></param>
        public void EditContact(DataTable table)
        {
            var contacts = table.AsEnumerable().Where(x => x.Field<string>("FirstName") == "Naman");
            foreach (var contact in contacts)
            {
                contact.SetField("LastName", "Mahi");
                contact.SetField("City", "Banglore");
                contact.SetField("State", "Karnataka");
                contact.SetField("Email", "mahi@yahoo.com");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Following is recently Updated Contact");
            DisplayContacts(contacts.CopyToDataTable());
        }
        /// <summary>
        /// Delet contact
        /// </summary>
        /// <param name="table"></param>
        public void DeleteContact(DataTable table)
        {
            var contacts = table.AsEnumerable().Where(r => r.Field<string>("FirstName") != "Yamini").CopyToDataTable();
            Console.WriteLine("Following Contacts are present in Datatable after deletion of Contact of Person 'Akshara' ");
            DisplayContacts(contacts);
        }

        /// <summary>
        /// Retrieve Contact Belonging To Perticular City OR State
        /// </summary>
        /// <param name="table"></param>
        public void RetrieveContactBelongingToPerticularCityORState(DataTable table)
        {
            var contacts = table.Rows.Cast<DataRow>()
                             .Where(x => x["City"].Equals("Chennai") || x["State"].Equals("Tamilnadu")).CopyToDataTable();
            Console.WriteLine("Following Contacts belonging to perticular City or State ");
            DisplayContacts(contacts);
        }
        /// <summary>
        /// Count Contacts From Perticular City AND State
        /// </summary>
        /// <param name="table"></param>
        public void CountContactsFromPerticularCityANDState(DataTable table)
        {
            var contacts = table.Rows.Cast<DataRow>()
                             .Where(x => x["City"].Equals("Banglore") && x["State"].Equals("KA")).Count();
            Console.WriteLine($"Count of Persons Beloning to City 'Baroda' and State 'MP' : {contacts} ");
        }
        /// <summary>
        ///Sort Contacts by first name 
        /// </summary>
        /// <param name="table"></param>
        public void SortContacts(DataTable table)
        {
            var contacts = table.Rows.Cast<DataRow>()
                           .OrderBy(x => x.Field<string>("FirstName"));
            Console.WriteLine("\n**************************************************");
            Console.WriteLine("\nSorted Contacts using Person's first name");
            DisplayContacts(contacts.CopyToDataTable());
        }

    }
}
}






