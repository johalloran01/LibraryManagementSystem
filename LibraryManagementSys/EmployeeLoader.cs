using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSys
{
    internal class EmployeeLoader
    {
        //Connect to the database
        static string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = LibraryDatabase.accdb;";
        OleDbConnection myConnection = new OleDbConnection(connection);
        DataSet employeeDataSet;
        OleDbDataAdapter objDataAdapter;
        DataTable tblEmployee;

        //Load the book datatable information 
        public DataTable DataLoad()
        {
            myConnection.Open();
            string readSQL = "SELECT * FROM tblEmployee;";
            employeeDataSet = new DataSet("EmployeeSet");
            objDataAdapter = new OleDbDataAdapter(readSQL, myConnection);
            objDataAdapter.Fill(employeeDataSet, "EmployeeSet");
            tblEmployee = employeeDataSet.Tables["EmployeeSet"];

            return tblEmployee;

        }

    }
}
