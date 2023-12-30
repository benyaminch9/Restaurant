using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public class Pay
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "سفارش دهنده")]
        [Required]
        [MaxLength(100)]
        public string UserID { get; set; }

        [Display(Name = " مبلغ کل")]
        [Required]
        public long Price { get; set; }

        [Display(Name = "تراکنش بانکی")]
        [MaxLength(200)]
        public string BankID { get; set; }

        [Display(Name = "مرجع بانکی")]
        [MaxLength(200)]
        public string RefrenceID { get; set; }

        [Display(Name = "وضعیت سفارش ")]
        public string Status { get; set; }
    }
}
