using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace SanduJewel.Models
{
    public class Owner
    {
        [Key]
        public string O_Name { get; set; }
        public int O_Contact_Number { get; set; }
        public string O_Email { get; set; }
        public virtual ICollection<Jewellery> Jewelleries { get; set; }


    }
}
