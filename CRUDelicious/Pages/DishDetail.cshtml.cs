using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDelicious.CORE;
using CRUDelicious.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDelicious.Pages
{
    public class DishDetailModel : PageModel
    {
        public Dishes DishModel { get; set; } 
        private DishService _dishService;

        public DishDetailModel( DishService dishService)
        {
            _dishService = dishService;
        }
        public void OnGet(int id)
        {
           this.DishModel = _dishService.GetItem(id);
        }
    }
}
