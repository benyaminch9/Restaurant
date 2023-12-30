using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public class Table
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "شماره میز")]
        public int TableNumber { get; set; }

        [Display(Name = "نفر")]
        public int Person { get; set; }

        [MaxLength(50)]
        [Display(Name = "تاریخ")]
        public string Date { get; set; }
        [MaxLength(50)]
        [Display(Name = "زمان")]
        public string Time { get; set; }
    }
}
