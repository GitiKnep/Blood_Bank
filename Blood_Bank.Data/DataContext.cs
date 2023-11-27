using Blood_Bank.Core.Entities;
namespace Blood_Bank.Data
{
    public class DataContext
    {
        public  List<Donors> DonorsList { get; set; }
        public  List<Donations> DonationsList { get; set; }
        public  List<Sicks> SicksList { get; set; }
        public DataContext()
        {
            DonorsList = new List<Donors>();
            DonorsList.Add(new Donors { idDonor = 1, fNameDonor = "shifi", lNameDonor = "weingarten", typeBloodDonor = "A", pelephoneDonor = "0556773857", statusDonor = 1 });
            DonationsList = new List<Donations>();
            DonationsList.Add(new Donations { idDonation = 2, idDonor =1 ,idSick=3,statusDonation=2 });
            SicksList = new List<Sicks>();
            SicksList.Add(new Sicks { idSick = 1, fNameSick = "shifi", lNameSick = "weingarten", typeBloodSick = "A", pelephoneSick = "0556773857", statusSick = 1 });

        }
    }
}
