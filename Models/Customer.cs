using System.ComponentModel.DataAnnotations;

namespace SanduJewel.Models
{
    public class Customer
    {
        [Key]
        public string J_number { get; set; }
        public string J_Category { get; set; }
        public string J_Weight { get; set; }
        public int J_Price { get; set; }
    }
}
