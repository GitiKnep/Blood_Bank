using System.ComponentModel.DataAnnotations;

namespace Blood_Bank.Core.Entities
{
    public class Donations
    {
        [Key]
        public int idDonation { get; set; }
        public int idSick { get; set; }
        public int idDonor { get; set; }
        public int statusDonation { get; set; }
    }
}
