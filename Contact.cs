using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mattson_AddressBookGUI
{
    class Contact
    {
        public string fName, lName, Address, City, State, Zip, phoneNum, Email; 



        public Contact(string fName, string lName, string Address, 
            string City, string State, string Zip, string phoneNum, string Email)
        {
            this.fName = fName;
            this.lName = lName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
            this.phoneNum = phoneNum;
            this.Email = Email;
        }

        public void printContact()
        {
            Console.WriteLine(fName + "\n" + lName + "\n" + Address + "\n" + City
                + "\n" + State + "\n" + Zip + "\n" + phoneNum + "\n" + Email);
        }
    }
}
