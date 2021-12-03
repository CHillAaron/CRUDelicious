using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDelicious.CORE
{
    public class Chef
    {
        [Key]
        public int ChefId { get; set; }
        [Required]
        public string ChefName { get; set; }
        [Required]
        public int Age { get; set; }
        public List<Dishes> AllDishes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }= DateTime.Now;
    }
}
