using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace SanduJewel.Models
{
    public class Order
    {
        [Key]
        public int O_ID { get; set; }
        public string O_Date { get; set; }
        //public int C_ID { get; set; }
        public virtual Customer Customer { get; set; }
        //public int P_ID { get; set; }
        public virtual Payment Payment { get; set; }
    }

}
