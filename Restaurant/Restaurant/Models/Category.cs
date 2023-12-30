using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "عنوان")]
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Display(Name = "تصویر")]
        [Required(AllowEmptyStrings =true)]
        [MaxLength(100)]
        public string Icon { get; set; }

        [Display(Name = "فعال/غیر فعال")]
        public bool Active { get; set; }

    }
}
