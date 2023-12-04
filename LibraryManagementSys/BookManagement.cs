using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryManagementSys
{
    internal class BookManagement
    {
        //Connect to the database
        static string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = LibraryDatabase.accdb;";
        OleDbConnection myConnection = new OleDbConnection(connection);


        //Add a book to the table 
        public void AddBook(Book book)
        {
            int id = book.bookIdNum;
            string title = book.bookTitle;
            string author = book.bookAuthor;
            string genre = book.bookGenre;
            string cover = book.bookCoverArt;
            bool availability = book.bookAvailability;

            myConnection.Open();

            string addSQL = $"INSERT INTO tblBook (BookID, BookTitle, BookAuthor, Genre, CoverArt, Availability) " + 
                $"VALUES ({id},'{title}','{author}','{genre}','{cover}',{availability});";
            OleDbCommand addCommand = new OleDbCommand(addSQL) ;
            addCommand.ExecuteNonQuery() ;

            myConnection.Close();

        }


        //Remove a book from the table 
        public void RemoveBook(Book book)
        {
            int id = book.bookIdNum;

            myConnection.Open();
            string removeSQL = $"DELETE FROM tblBook WHERE BookID = {id}";
            OleDbCommand removeCommand = new OleDbCommand(removeSQL) ;
            removeCommand.ExecuteNonQuery() ;
            myConnection.Close();

        }

        //Modify a book 
        public void UpdateBook(Book book)
        {
            int id = book.bookIdNum;
            string title = book.bookTitle;
            string author = book.bookAuthor;
            string genre = book.bookGenre;
            string cover = book.bookCoverArt;
            bool availability = book.bookAvailability;

            myConnection.Open();
            string modifySQL = $"UPDATE tblBook " +
                $"SET BookID = {id}, BookTitle = '{title}', BookAuthor = '{author}', Genre = '{genre}', CoverArt = '{cover}', Availability = '{availability}'" +
                $"WHERE BookID = {id};";
            OleDbCommand modifyCommand = new OleDbCommand(modifySQL) ;
            modifyCommand.ExecuteNonQuery() ;
            myConnection.Close();

        }


    }
}
