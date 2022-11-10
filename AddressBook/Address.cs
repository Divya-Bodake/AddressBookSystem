using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Address
    {
        List<Contact> address = new List<Contact>();
        public void AddContact()
        {
            Contact contact = new Contact();
            address.Add(contact);

            Console.WriteLine("Enter FirstName");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter LastName");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter Zip Code");
            contact.zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter PhoneNo");
            contact.PhoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email");
            contact.Email = Console.ReadLine();

            
        }
        public void Display()
        {
            foreach (var contact in address)
            {
                Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.zip + "\n" + contact.PhoneNumber + "\n" + contact.Email);
            }
        }
    }
}
