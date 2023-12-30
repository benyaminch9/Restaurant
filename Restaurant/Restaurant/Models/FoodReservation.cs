using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public class FoodReservation
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "عنوان غذا")]
        [Required]
        [MaxLength(100)]
        public string FoodTitle { get; set; }

        [Display(Name = "کد غذا")]
        [Required]
        [MaxLength(20)]
        public string FoodCode { get; set; }

        [Display(Name = "تعداد غذا")]
        [Required]
        public int Count { get; set; }

        [Display(Name = "قیمت غذا")]
        [Required]
        public long Price { get; set; }

        [Display(Name = "سایز غذا")]
        [Required]
        [MaxLength(100)]
        public string Size { get; set; }

        [Display(Name = " سفارش دهنده")]
        public string UserID { get; set; }

        [Display(Name = "وضعیت سفارش ")]
        public bool Status { get; set; }
    }
}
