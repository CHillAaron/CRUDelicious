using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDelicious.CORE
{
    public class Dishes
    {
        [Key]
        public int DishId { get; set; }
        [Required]
        public string DishName { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int Calories { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Range(1, 5)]
        public int Tastiness { get; set; }
        public int ChefId { get; set; }
        public Chef TheChef { get; set; }
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; }= DateTime.Now;
    }
}
