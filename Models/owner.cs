using System.ComponentModel.DataAnnotations;

namespace SanduJewel.Models
{
    public class owner
    {
        [Key]
        public string O_Name { get; set; }
        public int O_Contact_Number { get; set; }
        public string O_Email { get; set; }
       

    }
}
