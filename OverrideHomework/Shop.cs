using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideHomework
{
    internal class Shop
    {
        private string shop_name;
        private string address;
        private string description;
        private string phone;
        private string email;
        private double store_area;

        public Shop()
        {
            shop_name = string.Empty;
            address = string.Empty;
            description = string.Empty;
            phone = string.Empty;
            email = string.Empty;
            store_area = 0.0;
        }
        public Shop(string shop_name, string address, string description, string phone, string email,double store_area)
        {
            this.shop_name = shop_name;
            this.address = address;
            this.description = description;
            this.phone = phone;
            this.email = email;
            this.store_area= store_area;
        }

        public void Print() => Console.WriteLine("Shop name - " + shop_name + "\nAddress - " + address + "\nPhone number - " + phone + "\nDescription - " + description + "\nEmail - " + email + "\nStore area - " + store_area);
        public void Input()
        {
            Console.Write("Enter Shop name: ");
            shop_name = Console.ReadLine();
            Console.Write("Enter Address: ");
            address = Console.ReadLine();
            Console.Write("Enter Description: ");
            description = Console.ReadLine();
            Console.Write("Enter Phone number: ");
            phone = Console.ReadLine();
            Console.Write("Enter Email: ");
            email = Console.ReadLine();
            Console.Write("Enter Store Area: ");
            store_area = Convert.ToDouble(Console.ReadLine());
        }
        public override string ToString()
        {
            return "Shop name - " + shop_name + "\nAddress - " + address + "\nPhone number - " + phone + "\nDescription - " + description + "\nEmail - " + email + "\nStore area - " + store_area;
        }

        public string Shop_Name
        {
            get { return shop_name; }
            set { shop_name = value; }
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

        public double Store_Area
        {
            get { return store_area; }
            set
            {
                store_area = value;
            }
        }

        public static Shop operator +(Shop op1, double op2)
        {
            op1.store_area += op2;
            return op1;
        }
        public static Shop operator -(Shop op1, double op2)
        {
            op1.store_area -= op2;
            return op1;
        }
        public static bool operator ==(Shop op1, Shop op2)
        {
            return op1.store_area == op2.store_area;
        }
        public static bool operator !=(Shop op1, Shop op2)
        {
            return op1.store_area != op2.store_area;
        }
        public static bool operator >(Shop op1, Shop op2)
        {
            return op1.store_area > op2.store_area;
        }
        public static bool operator <(Shop op1, Shop op2)
        {
            return op1.store_area < op2.store_area;
        }
        public static bool operator >(Shop op1, int op2)
        {
            return op1.store_area > op2;
        }
        public static bool operator <(Shop op1, int op2)
        {
            return op1.store_area < op2;
        }


    }
}