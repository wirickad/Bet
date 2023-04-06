using System.ComponentModel.DataAnnotations;

namespace BetAPI.Data
{
    public class MarriottFood
    {
        [Key]
        public int FoodId { get; set; }
        public string? EventName { get; set; }
        public string? Vendor { get; set; }

        public int? Rating { get; set; }
    }
}
