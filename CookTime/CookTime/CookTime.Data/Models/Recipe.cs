using System.ComponentModel.DataAnnotations;

namespace CookTime.Data.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(20)]
        public string Category { get; set; }

        [Required]
        public string Products { get; set; }

        public byte[] Img { get; set; }

        public byte[] Video { get; set; }
    }
}
