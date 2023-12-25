using System.ComponentModel.DataAnnotations;

namespace Blood_Bank.Core.Entities
{
    public class Donors
    {
        [Key]
        public int idDonor { get; set; }
        public string? fNameDonor { get; set; }
        public string? lNameDonor { get; set; }
        public string? typeBloodDonor { get; set; }
        public string? pelephoneDonor { get; set; }
        public int statusDonor { get; set; }
    }
}
