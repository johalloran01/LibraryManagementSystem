using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSys

// Chloe Caplan 

{
    public class Member
    {
        // declarations for the members class 
        public int memberID;
        private string name;
        private string address;
        private string email;
        private int phoneNumber;
        public List<Transaction> transactions;
        private double outstandingFines;
        DateTime hireDate;
        private string libraryCard;
        private string location;

        // initializers for the library class 
        public Member(int memberID, string name, string address, string email, int phoneNumber, List<Transaction> transactions, double outstandingFines, DateTime hireDate, string libraryCard)
        {
            this.memberID = MemberIDGenerator();
            this.name = name;
            this.address = address;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.transactions = transactions;
            this.outstandingFines = outstandingFines;
            this.hireDate = hireDate;
            this.libraryCard = libraryCard;
        }

        // randomly generates a unique 9 digit ID for a member
        private int MemberIDGenerator()
        {
            Random random = new Random();
            return random.Next(000000, 999999);

        }

        // getters and setters 
        public int MemberID
        {
            get { return memberID; }
            set { memberID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public List<Transaction> Transactions
        {
            get { return transactions; }
            set { transactions = value; }
        }

        public double OutstandingFines
        {
            get { return outstandingFines; }
            set { outstandingFines = value; }
        }

        public DateTime HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }

        public string LibraryCard
        {
            get { return libraryCard; }
            set { libraryCard = value; }
        }

        // views a member's borrowing history
        public List<Transaction> ViewBorrowHistory()
        {
            return Transactions;
        }

        // once the fine is paid off, the payment is subtracted from the member's outstanding fines
        public void PayFine(double payment)
        {
            if (outstandingFines > 0)
            {
                if (payment <= outstandingFines)
                {
                    outstandingFines -= payment;
                }
            }
        }

        // shows the member's current fines
        public double ViewFine()
        {
            return outstandingFines;
        }

        // verifies that the library card is valid 
        public bool CheckLibraryCard()
        {
            bool validCard = libraryCard.Length == 9;
            return validCard;
        }

        // checks to see if the account is still in good standing (the member has no fines due)
        public bool AccountStanding()
        {
            bool accountStatus = outstandingFines > 0;
            return accountStatus;
        }
    }
}
