using Space_Shuttle.Common.Interfaces;

namespace Space_Shuttle.Common.Classes
{
    public class Customer : IPerson
    {
        public int CustomerID { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }


        public Customer(int customerID, string firstName, string lastName, string socialSecurityNumber)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }

        public override string ToString() => $"{FirstName} {LastName} ({SocialSecurityNumber})";
        
    }
}
