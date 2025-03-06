using System.ComponentModel.DataAnnotations;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime BirthDate { get; set; }
        //public int ID { get; set; }
        [EmailAddress]
        public string EmailAdress { get; set; }
        [RegularExpression("^[0-9]{8}$", ErrorMessage = "Telephone Number must contain exactly 8 digits.")]
        public int TelNumber { get; set; }
        [Key]
        [StringLength(7)]
        public string PassportNumber { get; set; }
        public ICollection<Flight> Flights { get; set; }
        public FullName FullName { get; set; }
        public ICollection<ReservationTicket> Reservations { get; set; }


        public bool checkprofile(string nom, string prenom, string mail = null)
        {
            if (mail == null)
                return nom == FullName.FirstName && prenom == FullName.LastName;
            return nom == FullName.FirstName && prenom == FullName.LastName && mail == EmailAdress;
        }

        public virtual void passengertype()
        {
            Console.WriteLine("i am passenger");
        }

    }
}
