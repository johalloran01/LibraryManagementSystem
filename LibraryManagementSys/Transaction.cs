using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSys
{
    public class Transaction
    {
        //Transaction class will consist of the following fields 
        private int transactionId; 
        private List<Book> books;
        private int memberId;
        private int employeeId;
        DateTime checkOutDate;
        DateTime dueDate;
        DateTime returned;
        private bool transactionClosed;
        private double fine; 

        //Getters and Setters 
        double transactionFine
        {
            get { return fine; }
            set { fine = value; }
        }

        int transaction
        {
            get { return transactionId; }
            
        }

        int member
        {
            get { return memberId; }
            set { memberId = value; }
        }

        int employee
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        DateTime checkOut
        {
            get { return checkOutDate; }
            set { checkOutDate = value; }
        }

        DateTime due
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        DateTime returnedDate
        {
            get { return returned; }
            set { returnedDate = value; }
        }

        bool transactionStatus
        {
            get { return transactionClosed; }
            set { transactionClosed = value; }
        }

        //Transaction ID generator 000000 to 999999
        private int TransactionIdGenerator()
        {
            Random random = new Random();
            return random.Next(000000, 999999);
        }        

        //Constructor 
        public Transaction(int _member, int _employee)
        {
            this.memberId = _member;
            this.employee = _employee;
            this.books = new List<Book>();
            this.transactionStatus = false;
            this.transactionId = TransactionIdGenerator();
            this.checkOut = DateTime.Now;
            this.due = checkOut.AddDays(14);
            this.fine = 0.0 + (0.2 * (returnedDate - due).TotalDays); 

        }

        //Methods for tracking/modifying/updating information 
        public bool CheckTransactionStatus(Transaction transaction)
        {
            return transaction.transactionStatus;
        }

        public void UpdateTransactionStatus(Transaction transaction, bool status)
        {
            if (status !=  transaction.transactionStatus)
            {
                transaction.transactionStatus = status;
            } throw new Exception("Transaction Status already set this this value.");
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public void PayFine(Transaction transaction, double payment)
        {
            if (transaction.fine != 0.0)
            {
                transaction.fine = transaction.fine - payment; 
            } throw new Exception("There are no outstanding fines for this transaction.");
        }

        public void ExtendDueDate(Transaction transaction, int days)
        {
            transaction.dueDate = transaction.dueDate.AddDays(days);
        }

        public void Returned(Transaction transaction)
        {
            transaction.returnedDate = DateTime.Now;
            transaction.transactionStatus = true; 
        }

        // when a book is returned, the system checks if the book is overdue. If so, the member is charged a 0.20 fine per day overdue
        public void ReturnBook(Member member)
        {
            DateTime bookDueDate = dueDate;
            DateTime bookReturnDate = DateTime.Now;

            if (bookReturnDate > bookDueDate)
            {
                int daysOverdue = (int)(bookReturnDate - bookDueDate).TotalDays;
                double totalFine = daysOverdue * 0.20;
                member.OutstandingFines += totalFine;
            }
        }







    }
}
