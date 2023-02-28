using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace SanduJewel.Models
{
    public class Jewellerycs
    {
        [Key]
        public int J_number { get; set; }
        public string J_Category { get; set; }
        public int J_Weight { get; set; }
        public int J_Price { get; set; }
      

    }
}
