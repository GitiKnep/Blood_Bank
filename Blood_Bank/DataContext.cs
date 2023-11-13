using Blood_Bank.Entities;
namespace Blood_Bank
{
    public class DataContext
    {
        public  List<Donors> DonorsList {  get; set; }
        public  List<Donations> DonationsList { get; set; }
        public List<Sicks> SicksList { get; set; }
        public DataContext() 
        { 
            DonorsList = new List<Donors>(); 
            DonorsList.Add(new Donors { idDonor=1, fNameDonor="Giti", lNameDonor="Knepelmacher",typeBloodDonor="A", pelephoneDonor="0548451325",statusDonor=0});
            DonationsList = new List<Donations>();
            DonationsList.Add(new Donations { idDonation = 1, idDonor = 1, idSick = 1, statusDonation = 1 });
            SicksList = new List<Sicks>();  
            SicksList.Add(new Sicks { idSick = 1,fNameSick="fname",lNameSick="lname",typeBloodSick="A",pelephoneSick="0504115587",statusSick=0});   
        }

    }
}
