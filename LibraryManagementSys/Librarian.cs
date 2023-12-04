using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSys
{// Chloe Caplan
        public class Librarian
        {
            // declarations for the librarian class 
            private int employeeId;
            private string name;
            private string position;
            DateTime hireDate;
            private string location;
            private List<Member> members = new List<Member>();
            private Library theLibrary;

            // initializers for the librarian class 
            public Librarian(int employeeId, string librarianName, string position, DateTime hireDate, string library)
            {
                this.employeeId = EmployeeIdGenerator();
                this.name = librarianName;
                this.position = position;
                this.hireDate = hireDate;
                this.location = library;
            }

            // Getters and Setters
            public int EmployeeID
            {
                get { return employeeId; }
                set { employeeId = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public string Position
            {
                get { return position; }
                set { position = value; }
            }

            public DateTime HireDate
            {
                get { return hireDate; }
                set { hireDate = value; }
            }

            public string Library
            {
                get { return location; }
                set { location = value; }
            }

            // returns a list of a member's transactions
            public List<Transaction> GetTransactions(Member member)
            {
                return member.transactions;
            }

            // the librarian can add a new member to their system
            public void AddMember(int memberId, string name, string address, string email, int phoneNumber, List<Transaction> transactions, double outstandingFines, DateTime hireDate, string libraryCard)
            {
                Member newMember = new Member(memberId, name, address, email, phoneNumber, transactions, outstandingFines, hireDate, libraryCard);
                members.Add(newMember);
            }

            // the librarian can delete a member to their system
            public void RemoveMember(Member oldMember)
            {
                if (oldMember == null)
                {
                    members.Remove(oldMember);
                }
            }

            // the librarian can view a member's information
            public Member ViewMember(Member memberID)
            {
                Member selectedMember = memberID;
                return selectedMember;
            }

            // the librarian can modify a member if their information needs to be changed
            public Member ModifyMember(int memberID)
            {
                List<Member> membersList = theLibrary.GetMemberById(memberID);
                if (membersList != null && membersList.Count > 0)
                {
                    Member updateMember = membersList[0];
                    return updateMember;
                }
                else
                {
                    return null;
                }
            }

            // Checks to see the member is in good standing (has no fines) before allowing them to check out the book
            public bool BorrowBook(int memberId)
            {
                List<Member> membersList = theLibrary.GetMemberById(memberId);
                if (membersList != null && membersList.Count > 0)
                {
                    Member memberBook = membersList[0];
                    if (memberBook.AccountStanding())
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }

            }

            // randomly generates a unique 9 digit ID for a library card
            public int GiveLibraryCard()
            {
                Random random = new Random();
                return random.Next(000000, 999999);
            }

            // randomly generates a unique 9 digit ID for an employee
            private int EmployeeIdGenerator()
            {
                Random random = new Random();
                return random.Next(000000, 999999);

            }

        }

    }
