using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    internal class Customer
    {
        //Static field to hold the next ID available
        private static int nextId = 0;
        //Read only instance field 
        private readonly int _id;
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        private string _password;

        public int Id { get
            { return _id; }
        }

        public string Password
        {
            set { _password = value; }
        }


        //Custom constructor
        //Default optional parameters address & contactNumber
        public Customer(string name, string address, string contactNumber)
        {
            _id = nextId++;
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public Customer(string name)
        {
            _id=nextId++;
            Name = name;
        }

        //Default Constructor
        public Customer() 
        {
            _id = nextId++;
            Name = "New name";
            Address = "Unknown";
            ContactNumber = "Unknown";
        }

        public void GetDetails()
        {
            Console.WriteLine($"Details about the customer: Name is {Name} and ID is {_id} and Password is {_password}");
        }

        public void setDetails(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }
    }

}
