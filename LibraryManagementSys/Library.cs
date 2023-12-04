using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSys
{
    //Chloe Caplan
    public class Library
    {
        // declarations for the library class 
        private string name;
        private string location;
        private string operatingHours;
        private List<Librarian> librarians;
        private List<Member> member;
        private List<Transaction> transaction;

        // initializers for the library class 
        public Library(string name, string location, string operatingHours, List<Librarian> employees, List<Member> members, List<Transaction> transaction)
        {
            this.name = name;
            this.location = location;
            this.operatingHours = operatingHours;
            this.librarians = employees;
            this.member = members;
            this.transaction = transaction;
        }
        // getters and setters for the library class 
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public string OperatingHours
        {
            get { return operatingHours; }
            set { operatingHours = value; }
        }

        public List<Librarian> Employees
        {
            get { return librarians; }
            set { librarians = value; }
        }

        public List<Member> Members
        {
            get { return member; }
            set { member = value; }
        }

        public List<Transaction> Transactions
        {
            get { return transaction; }
            set { transaction = value; }
        }

        // Each library is assigned its own catalog of books and is returned 
        

        // finds an employee by their name and returns the match
        public List<Librarian> GetEmployeeByName(string name)
        {
            List<Librarian> employeeName = new List<Librarian>();
            foreach (var employee in librarians)
            {
                if (employee.Name == name)
                {
                    employeeName.Add(employee);
                }
            }
            return employeeName;
        }

        // finds an employee by their ID and returns the match
        public List<Librarian> GetEmployeeByID(int ID)
        {
            List<Librarian> employeeID = new List<Librarian>();
            foreach (var employee in librarians)
            {
                if (employee.EmployeeID == ID)
                {
                    employeeID.Add(employee);
                }
            }
            return employeeID;
        }

        // finds an employee by their position and returns the match
        public List<Librarian> GetEmployeeByPosition(string position)
        {
            List<Librarian> employeePosition = new List<Librarian>();
            foreach (var employee in librarians)
            {
                if (employee.Position == position)
                {
                    employeePosition.Add(employee);
                }
            }
            return employeePosition;
        }

        // finds an employee by their hire date and returns the match
        public List<Librarian> GetEmployeeByTenure(int years)
        {
            List<Librarian> employeeTenure = new List<Librarian>();
            foreach (var employee in librarians)
            {
                int employeeHireDate = DateTime.Now.Year - employee.HireDate.Year;

                if (employeeHireDate == years)
                {
                    employeeTenure.Add(employee);
                }
            }
            return employeeTenure;
        }

        // finds a member by their name and returns the match
        public List<Member> GetMemberByName(string name)
        {
            List<Member> memberName = new List<Member>();
            foreach (var member in member)
            {
                if (member.Name == name)
                {
                    memberName.Add(member);
                }
            }
            return memberName;
        }

        // finds a member by their ID and returns the match
        public List<Member> GetMemberById(int Id)
        {
            List<Member> memberID = new List<Member>();
            foreach (var member in member)
            {
                if (member.MemberID == Id)
                {
                    memberID.Add(member);
                }
            }
            return memberID;
        }

        // returns the total amount of transactions a library has completed 
        public int TotalTransactions()
        {
            return Transactions.Count;
        }
    }
}
