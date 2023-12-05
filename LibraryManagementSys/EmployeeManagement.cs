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

            int id = employee.EmployeeID;
            string name = employee.Name;
            string position = employee.Position;
            DateTime tenure = employee.HireDate;
            string location = employee.Library;

            myConnection.Open();

            string addSQL = $"INSERT INTO tblEmployee (EmployeeID, EmployeeName, Position, Tenure, Location, HireDate) " +
                $"VALUES ({id},'{name}','{position}','{tenure}','{location}');";
            OleDbCommand addCommand = new OleDbCommand(addSQL);
            addCommand.ExecuteNonQuery();

            myConnection.Close();

        }
        public void RemoveEmployee(Librarian employee)
        {
            int id = employee.EmployeeID;

            myConnection.Open();
            string removeSQL = $"DELETE FROM tblEmployee WHERE EmployeeID = {id}";
            OleDbCommand removeCommand = new OleDbCommand(removeSQL);
            removeCommand.ExecuteNonQuery();
            myConnection.Close();

        }

        //Modify an employee 
        public void UpdateEmployee(Librarian employee)
        {
            int id = employee.EmployeeID;
            string name = employee.Name;
            string position = employee.Position;
            DateTime tenure = employee.HireDate;
            string location = employee.Library;

            myConnection.Open();
            string modifySQL = $"UPDATE tblEmployee " +
                $"SET EmployeeID = {id}, EmployeeName = '{name}', Position = '{position}', Tenure = '{tenure}', Location = '{location}'" +
                $"WHERE EmployeeID = {id};";
            OleDbCommand modifyCommand = new OleDbCommand(modifySQL);
            modifyCommand.ExecuteNonQuery();
            myConnection.Close();

        }
    }
}
