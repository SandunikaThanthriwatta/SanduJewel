using System.ComponentModel.DataAnnotations;

namespace SanduJewel.Models
{
    public class Customer
    {
        [Key]
        public int C_NIC { get; set; }
        public string C_Name { get; set; }
        public int C_Contact_Number { get; set; }
        public string C_Email { get; set; }
        public string C_Address { get; set; }
        public int C_BirthDay { get; set; }
    }
}
