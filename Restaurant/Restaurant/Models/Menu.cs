using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public class Menu
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "عنوان غذا")]
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Display(Name = "کد غذا")]
        [Required]
        [MaxLength(20)]
        public string FoodCode { get; set; }

        [Display(Name = "سایز غذا")]
        [Required]
        [MaxLength(50)]
        public string Size { get; set; }

        [Display(Name = "قیمت غذا")]
        [Required]
        public long Price { get; set; }

        [Display(Name = "توضیحات ")]
        [MaxLength(250)]
        public string Description { get; set; }

        [Display(Name = "گروه ")]
        public int Dastehid { get; set; }

        [Display(Name = "برچسب")]
        [Required]
        [MaxLength(100)]
        public string Tag { get; set; }
    }
}
