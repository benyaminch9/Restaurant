using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public class TableReservation
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "نام و نام خانوادگی")]
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Display(Name = "موبایل")]
        [Required]
        [MaxLength(11)]
        public string Phone { get; set; }

        [Display(Name = "تاریخ")]
        [Required]
        [MaxLength(11)]
        public string Date { get; set; }

        [Display(Name = "زمان")]
        [Required]
        [MaxLength(6)]
        public string Time { get; set; }

        [Display(Name = "شماره میز")]
        [Required]
        public int Count { get; set; }

        [Display(Name = "ایمیل")]
        [Required(AllowEmptyStrings =true)]
        [MaxLength(100)]
        public string Email { get; set; }

        [Display(Name = "پیغام")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(200)]
        public string Message { get; set; }

        [Display(Name = "تایید/تایید نشده")]
        public bool ActiveOrDiActive { get; set; }
    }
}
