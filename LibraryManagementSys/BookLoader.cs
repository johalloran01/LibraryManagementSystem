using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSys.LibraryDatabaseDataSetTableAdapters;

namespace LibraryManagementSys
{
    internal class BookLoader
    {
        //Connect to the database
        static string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = LibraryDatabase.accdb;";
        OleDbConnection myConnection = new OleDbConnection(connection);
        DataSet bookDataSet;
        OleDbDataAdapter objDataAdapter;
        DataTable tblBook;

        //Load the book datatable information 
        public DataTable DataLoad()
        {
            myConnection.Open();
            string readSQL = "SELECT * FROM tblBook;";
            bookDataSet = new DataSet("BookSet");
            objDataAdapter = new OleDbDataAdapter(readSQL, myConnection);
            objDataAdapter.Fill(bookDataSet, "BookSet");
            tblBook = bookDataSet.Tables["BookSet"];

            return tblBook;

        }

        //Load bookTransactions
        public DataTable LoadBookTransactions()
        {
            myConnection.Open();
            string transactionReader = "SELECT * FROM tblBookTransactions;";
            DataSet dataSet = new DataSet("BookTransactions");
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(transactionReader, myConnection);
            dataAdapter.Fill(dataSet, "BookTransactions");
            DataTable tblBookTransactions = dataSet.Tables["BookTransactions"];
            
            return tblBookTransactions;
        }



    }
}
