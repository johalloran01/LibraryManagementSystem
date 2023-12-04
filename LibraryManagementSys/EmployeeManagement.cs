using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSys
{
    internal class EmployeeManagement
    {

        //Connect to the database 
        static string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = LibraryDatabase.accdb;";
        OleDbConnection myConnection = new OleDbConnection(connection);

        //Add an employee 
        public void AddEmployee(Librarian employee)
        {
           



        }

        //Delete an employee 


        //Modify an employee 



    }
}
