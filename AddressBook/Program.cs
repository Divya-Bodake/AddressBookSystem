namespace AddressBook
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Address address = new Address();
                Console.WriteLine("\nselect Program\n 1.AddContacts");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        address.AddContact();
                        break;
                    case 2:
                        address.Display();
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