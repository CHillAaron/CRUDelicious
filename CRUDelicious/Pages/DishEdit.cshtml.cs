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
    public class DishEditModel : PageModel
    {
        private DishService _dishService;
        public Dishes DishModel { get; set; }
        public List<SelectListItem> likeness =>
        Enumerable.Range(1, 5).Select(x => new SelectListItem
        {
            Value = x.ToString(),
            Text = x.ToString()
        }).ToList();

        public DishEditModel(DishService dishService)
        {
            _dishService = dishService;
        }
        public void OnGet(int id)
        {
            this.DishModel = _dishService.GetItem(id);
        }
        public IActionResult OnPost(Dishes DishModel)
        {
            var someText = DishModel;
            if (this.ModelState.IsValid)
            {
                DishModel.UpdatedAt = DateTime.Now;
                _dishService.UpdateItem(DishModel);
                return RedirectToPage($"Index");
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
