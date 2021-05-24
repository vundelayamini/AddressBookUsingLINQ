using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;


namespace AddressBookUsingLinq
{
    class AddressBookDataTable
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
    }

}
