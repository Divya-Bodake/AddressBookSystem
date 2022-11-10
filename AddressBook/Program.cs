﻿namespace AddressBook
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            Address address = new Address();
            while (flag)
            {
                
                Console.WriteLine("\nselect Program\n 1.AddContacts \n 2.Display \n 3.EditContact"  );
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        address.AddContact();
                        break;
                    case 2:
                        address.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter Name of Contact you want to edit");
                        string name = Console.ReadLine();
                        address.EditContact(name);
                        break;
                            
                    default:
                        Console.WriteLine("Invalid choice");
                        flag = false;
                        break;
                        
                }

            }
        }
    }
}