using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSys; 

namespace LibraryManagementSys
{
    public class Catalog
    {
        //Fields for catalog 
        private List<Book> catalogBooks;


        //Getters and setter 
        public List<Book> getCatalog
        {
            get { return catalogBooks; }
            set { catalogBooks = value; }

        }

        //Methods 
        public void AddBook(Book book)
        {
            getCatalog.Add(book);
        }

        public void RemoveBook(Book book)
        {
            getCatalog.Remove(book);
        }

        public int GetCatalogSize(Catalog catalog)
        {
            return getCatalog.Count;
        }

        //Method for books by title

        public int GetBookCountTitle(string bookTitle)
        {
            int count = 0;

            foreach( Book book in catalogBooks)
            {
                if (book.booktitle == bookTitle)
                {
                    count++;
                    
                }
            }
            return count;
        }

        public List<Book> SearchBookByTitle(string title)
        {
            List<Book> bookByTitle = new List<Book>();
            foreach( Book book in catalogBooks)
            {
                if(book.booktitle == title)
                {
                    bookByTitle.Add(book);
                }
            }

            return bookByTitle;
        }




        //Methods for books by  author

        public int GetBookCountAuthor(string bookAuthor)
        {
            int count = 0;
            foreach( Book book in catalogBooks)
            {
                if (book.bookauthor == bookAuthor)
                {
                    count++;
                }
            }
            return count;
        }

        public List<Book> SearchBookByAuthor(string author)
        {
            List<Book> bookByAuthor = new List<Book>();
            foreach(Book book in catalogBooks)
            {
                if(book.bookauthor == author)
                {
                    bookByAuthor.Add(book);
                }
            }
            return bookByAuthor;
        }

        //Methods for books by genre

        public int GetBookCountGenre(string genre)
        {
            int count = 0;
            foreach(Book book in catalogBooks)
            {
                if(book.bookgenre == genre)
                {
                    count++;
                }
            }
            return count;
        }

        public List<Book> SearchBookByGenre(string genre)
        {
            List<Book> bookByGenre = new List<Book>();
            foreach(Book book in catalogBooks)
            {
                if(book.bookgenre == genre)
                {
                    bookByGenre.Add(book);
                }
            }
            return bookByGenre; 
        }
        
        //Methods for books by idNumber
        public int GetBookCountID(int bookID)
        {
            int count = 0;
            foreach( Book book in catalogBooks)
            {
                if (book.BookId == bookID)
                {
                    count++;
                }
            }
            return count;
        }

        public List<Book> SearchBookByID(int bookID)
        {
            List<Book> bookById = new List<Book>();
            bool verify = Utils.IsCorrectNumberOfDigits(bookID, 6);

            if (!verify)
            {
                throw new Exception("Please verify you entered the correct Book ID number.");
            }else
            {
                foreach(Book book in catalogBooks)
                {
                    if(book.BookId == bookID)
                    {
                        bookById.Add(book);
                    }
                }
            }
            return bookById;
        }

    }
}





