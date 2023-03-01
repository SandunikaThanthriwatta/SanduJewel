using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace SanduJewel.Models
{
    public class Payment
    {
        [Key]
        public int P_ID { get; set; }
        public string P_Method { get; set; }
        public int P_Status { get; set; }
        public int P_Date { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}
