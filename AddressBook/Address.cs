using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBook
{
    internal class Address
    {
        
        
        List<Contact> address = new List<Contact>();
        public void Display()
        {
            foreach (var contact in address)
            {
                Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.zip + "\n" + contact.PhoneNumber + "\n" + contact.Email);
            }
        }
        public void AddContact()
        {
            Contact contact = new Contact();

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

            address.Add(contact);
            
        }
        public void EditContact(string name)
        {
            //AddContact();
            foreach (var contact in address)
            {
                if (contact.FirstName == name)
                {
                    Console.WriteLine("---------------------------\n");
                    Console.WriteLine("Enter The Option To Update");
                    Contact contact1 = new Contact();
                    Console.WriteLine("1.FirstName \n 2.LastName \n 3.Address \n 4.City \n 5.State \n 6.zip \n 7.PhoneNumber \n 8.Email ");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter FirstName to Update");
                            contact.FirstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter LastName to Update");
                            contact.LastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter Address to Update");
                            contact.Address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter City to Update");
                            contact.City = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter State to Update");
                            contact.State = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter Zip to Update");
                            contact.zip = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 7:
                            Console.WriteLine("Enter PhoneNo to Update");
                            contact.PhoneNumber = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("Enter Email to Update");
                            contact.Email = Console.ReadLine();
                            break;

                            Console.WriteLine("....Edited Contact List........");
                            Display();
                    }
                    
                }
                else
                {
                    Console.WriteLine("Unable to find name in address book");
                }
            }
        }
        public void DeleteContact(string name)
        {
            try
            {
                foreach (var contact in address.ToList())
                {
                    if (contact.FirstName.Equals(name))
                    {
                        address.Remove(contact);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
