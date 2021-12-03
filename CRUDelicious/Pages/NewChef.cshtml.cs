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
    public class NewChefModel : PageModel
    {
        [BindProperty]
        public Chef Input { get; set; }
        private ChefService _chefService;

        public NewChefModel(ChefService chefService)
        {
            _chefService = chefService;
        }
        public void OnGet()
        {
            Input = new Chef();
        }
        public IActionResult OnPost()
        {
            var newDish = Input;
            if (this.ModelState.IsValid)
            {
                _chefService.AddItem(Input);
                return RedirectToPage("Index");
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
