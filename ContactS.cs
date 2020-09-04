using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mattson_AddressBookGUI
{

    // ARRAY OF CONTACT OBJECTS!!

    class ContactS
    {
        public Contact[] addressBook = new Contact[2];

        StreamReader readFile = new StreamReader("address.txt");

        public ContactS()
        {
            fillBook();
        }


        public void fillBook()
        {
            // use text file to populate addressbook array
            string fName, lName, Address, City, State, Zip, phoneNum, Email;
            

            for (int i=0; i<addressBook.Length; i++) // testing with 1 contact
            {
                // write text file and set each string to next readLine()
                fName = readFile.ReadLine();     
                lName = readFile.ReadLine();
                Address = readFile.ReadLine();
                City = readFile.ReadLine();
                State = readFile.ReadLine();
                Zip = readFile.ReadLine();
                phoneNum = readFile.ReadLine();
                Email = readFile.ReadLine();

                addressBook[i] = new Contact(fName, lName, Address, City, State, Zip, phoneNum, Email);
            }

        }

        

    }
}
