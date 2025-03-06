using System.ComponentModel.DataAnnotations;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        [MinLength(3,ErrorMessage ="min 3"), MaxLength(25,ErrorMessage ="max 25")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
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
