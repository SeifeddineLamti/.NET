namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int ID { get; set; }
        public string EmailAdress { get; set; }
        public int TelNumber { get; set; }
        public string PassportNumber { get; set; }
        public ICollection<Flight> Flights { get; set; }


        public bool checkprofile(string nom, string prenom, string mail = null)
        {
            if (mail == null)
                return nom == FirstName && prenom == LastName;
            return nom == FirstName && prenom == LastName && mail == EmailAdress;
        }

        public virtual void passengertype()
        {
            Console.WriteLine("i am passenger");
        }

    }
}
