using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace SanduJewel.Models
{
    public class Jewellery
    {
        [Key]
        public int J_number { get; set; }
        public string J_Category { get; set; }
        public int J_Weight { get; set; }
        public int J_Price { get; set; }
        public int C_ID{ get; set; }
        public virtual Customer Customer { get; set; }
        public int O_ID { get; set; }
        public virtual Owner Owner { get; set; }


    }
}
