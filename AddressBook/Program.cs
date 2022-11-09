namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact()
            {
                FirstName = "D",
                LastName = "B",
                Address = "CooperColony",
                City = "Satara",
                State = "Maharashtra",
                zip = 374856,
                PhoneNumber = 1234567890,
                Email = "Div@gmail.com"
            };
            Console.WriteLine(contact.FirstName + " " + contact.LastName + " " + contact.Address + " " + contact.City + " " + contact.State + " " + contact.zip + " " + contact.PhoneNumber + " " + contact.Email);
        }
    }
}