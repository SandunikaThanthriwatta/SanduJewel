using System.ComponentModel.DataAnnotations;

namespace SanduJewel.Models
{
    public class payment
    {
        [Key]
        public int P_ID { get; set; }
        public string P_Method { get; set; }
        public int P_Status { get; set; }
        public int P_Date { get; set; }

    }
}
