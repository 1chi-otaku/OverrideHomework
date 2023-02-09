using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace OverrideHomework
{
    internal class Journal
    {
        private string journal_name;
        private string address;
        private string description;
        private string phone;
        private string email;
        private uint employee_number;

        public Journal()
        {
            journal_name = string.Empty;
            address = string.Empty;
            description = string.Empty;
            phone = string.Empty;
            email = string.Empty;
            employee_number = 0;
        }
        public Journal(string journal_name, string address, string description, string phone, string email, uint employee_number)
        {
            this.journal_name = journal_name;
            this.address = address;
            this.description = description;
            this.phone = phone;
            this.email = email;
            this.employee_number = employee_number;

        }

        public void Print() => Console.WriteLine("Journal name - " + journal_name + "\nAddress - " + address + "\nPhone number - " + phone + "\nDescription - " + description + "\nEmail - " + email + "\nEmployee number - " + employee_number);
        public void Input()
        {
            Console.Write("Enter Journal name: ");
            journal_name = Console.ReadLine();
            Console.Write("Enter Address: ");
            address = Console.ReadLine();
            Console.Write("Enter Description: ");
            description = Console.ReadLine();
            Console.Write("Enter Phone number: ");
            phone = Console.ReadLine();
            Console.Write("Enter Email: ");
            email = Console.ReadLine();
            Console.Write("Enter Employee number: ");
            employee_number = Convert.ToUInt32(Console.ReadLine());

        }
        public string Journal_Name
        {
            get { return journal_name; }
            set { journal_name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
            }
        }
        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }
        public uint EmployeeNumber
        {
            get { return employee_number; }
            set
            {
                employee_number = value;
            }
        }
        public override string ToString()
        {
            return "Journal name - " + journal_name + "\nAddress - " + address + "\nPhone number - " + phone + "\nDescription - " + description + "\nEmail - " + email + "\nEmployee number - " + employee_number;
        }
        public static Journal operator +(Journal op1, uint op2)
        {
            op1.employee_number += op2;
            return op1;
        }
        public static Journal operator -(Journal op1, uint op2)
        {
            op1.employee_number -= op2;
            return op1;
        }
        public static bool operator ==(Journal op1, Journal op2)
        {
           return op1.employee_number== op2.employee_number;
        }
        public static bool operator !=(Journal op1, Journal op2)
        {
            return op1.employee_number != op2.employee_number;
        }
        public static bool operator >(Journal op1, Journal op2)
        {
            return op1.employee_number > op2.employee_number;
        }
        public static bool operator <(Journal op1, Journal op2)
        {
            return op1.employee_number < op2.employee_number;
        }
        public static bool operator >(Journal op1, int op2)
        {
            return op1.employee_number > op2;
        }
        public static bool operator <(Journal op1, int op2)
        {
            return op1.employee_number < op2;
        }
    }
}