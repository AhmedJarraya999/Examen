using System.ComponentModel.DataAnnotations;

namespace Examen.ApplicationCore.Domain
{
    public class Passenger
    {
        [Key]//cle primaire
        [StringLength(7)] // nbre des characteres fl string bethabt 
        public string PassportNumber { get; set; }
        [MaxLength(25 ,ErrorMessage ="invalid FirstName !")]
        [MinLength(3 , ErrorMessage ="invalid LastName ")]
        //hethy tari9a loula 
        public string FirstName { get; set; }
        //hethy tari9a thenya (nafs lobjectif) 
        //{3,25} : 3 lmin w 25 lmax / farthan 7atina {8} ma3neha toul el lastname 8 characteret bethabt 
        [RegularExpression(@"^[a-zA-Z]{3,25}$", ErrorMessage = "Invalid LastName!")]
        public string LastName { get; set; }
        [DataType(DataType.Date)] // win nchouf kelmet type w nra kelmet valide fl question nsta3mel datatype 
        [Display(Name = "Date of birth")]// tbadel esm el colonne fl database 
        public DateTime BirthDate { get; set; }

        [RegularExpression(@"^[0-9]{8}$", ErrorMessage = "Invalid LastName!")]
        //[DataType(DataType.PhoneNumber)] 2eme methode pour valider qu'il est un numero de tel 
        public int TelNumber { get; set; }
        [DataType(DataType.EmailAddress)] // win nchouf kelmet type w nra kelmet valide fl question nsta3mel datatype 
        public string EmailAddress { get; set; }
        //prop de navigation
        //public virtual List<Flight> Flights { get; set; } ya hasra kona many to many 
        // tawa one to many m3a el ticket 
        public virtual List<Ticket> Tickets { get; set; }

        //hetha el polymirphsme par signature 
        // nafs lesm mta3 lmethoded ama ysirech el erreur khater mouch nafs el signature 
        // signature ( type de retour + parametres )
        public bool CheckProfile(string firstName, string lastName)
        {
            return FirstName == firstName && LastName == lastName;
        }
        //public bool CheckProfile(string firstName, string lastName, string email)
        //{
        //    return FirstName == firstName && LastName == lastName && EmailAddress == email;
        // }
        public bool CheckProfile(string firstName, string lastName, string email)
        {
            if (email != null)
                return FirstName == firstName && LastName == lastName &&
                EmailAddress == email;
            else
                return FirstName == firstName && LastName == lastName;
        }

        //hetha ploymorphisme par héritage 
        // ysirech el erreur ra8m esm lmethode nafsou fl passenger wl traveller wl staff 
        // khater ki t3ayet ll methode ythabet fl objet eli 3aytelha donc ya3ref anehi bethabt
        // virtual lezma bch yfhem eli bch t3awed tbadel fiha fl classe fille 
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a Passenger");
        }


        //tkhali el affichage mta3 objet passenger  fl console kif manhebouh ahna (tostring)
        public override string ToString() 
        {
            return "FirstName: " + FirstName + " LastName: " + LastName + " date of Birth:"+ BirthDate;
        }
    }
}