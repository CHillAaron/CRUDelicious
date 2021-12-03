using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDelicious.CORE;
using CRUDelicious.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRUDelicious.Pages
{
    public class NewDishModel : PageModel
    {
        [BindProperty]
        public Dishes Input { get; set; }
        private DishService _dishService;
        
        public List<SelectListItem> likeness =>
        Enumerable.Range(1, 5).Select(x => new SelectListItem
        {
            Value = x.ToString(),
            Text = x.ToString()
        }).ToList();
        
        public List<Chef> allChefs { get; set; }

        public NewDishModel(DishService dishService)
        {
            _dishService = dishService;
        }
        
        public void OnGet()
        {
            Input = new Dishes();
            allChefs = _dishService.GetAllChef().ToList();
            Console.WriteLine(allChefs);


        }
        public IActionResult OnPost()
        {
            var newDish = Input;
            if (this.ModelState.IsValid)
            {
                Input.CreatedAt = DateTime.Now;
                _dishService.AddItem(Input);
                return RedirectToPage("Index");
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
