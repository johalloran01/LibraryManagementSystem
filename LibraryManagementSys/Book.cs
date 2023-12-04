using LibraryManagementSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Book
{
	//Book class will consist of the following fields
	private string title;
    private string author;
    private int bookId; //"ISBN"
    private string genre;
    private bool availability;
	private List<Transaction> transactionList; //List of associated transactions specific to the book 
    private string coverArt; //URL string 

	//Getters and setters 
	public string bookTitle
	{
		get { return title; }
		set { title = value; }
	}

    public string bookAuthor
	{
		get { return author; }
		set { author = value; }
	}

    public int bookIdNum
	{
		get { return bookId; }

	}

    public string bookGenre
	{
		get { return genre; }
		set { genre = value; }
	}

    public bool bookAvailability
	{
		get { return availability; }
	}

	private List<Transaction> bookTransactionList
	{
		get { return transactionList; }
	}

    public string bookCoverArt
	{
		get { return coverArt; }
		set { coverArt = value; }
	}

    //Book ID Generator from 000000 to 999999
    private int BookIdGenerator()
    {
        Random random = new Random();
		return random.Next(000000, 999999);

    }

    //Blank Constructor
    public Book()
	{
		this.bookId = BookIdGenerator();
	}

	//Specific Constructor
	public Book(string _title, string _author, bool _availability, string _genre, string _coverArt)
	{
		this.title = _title;
		this.author = _author;
		this.bookId = BookIdGenerator();
		this.genre = _genre;
		this.availability = _availability;
		this.transactionList = new List<Transaction>();
		this.coverArt = _coverArt;
	}

	//Methods for tracking/modifying information
	public bool CheckAvailability(Book book)
	{
		return book.availability; 
	}

	public void ChangeAvailablility(bool _availability)
	{
		this.availability = _availability;
	}

    public void AddTransaction(Transaction tran)
	{
		this.bookTransactionList.Add(tran);
	}
	
	public Book AddCopy(Book book)
	{
        Book newCopy = new Book(book.bookTitle, book.bookAuthor, book.bookAvailability, book.bookGenre, book.bookCoverArt);
		return newCopy; 
	}

}
