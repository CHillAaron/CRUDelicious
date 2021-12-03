using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDelicious.CORE;
using CRUDelicious.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CRUDelicious.Pages
{
    public class DishModel : PageModel
    {
        private readonly ILogger<DishModel> _logger;
        private readonly DishService _dishService;

        public List<Dishes> allDishes = new List<Dishes>();

        public DishModel(ILogger<DishModel> logger, DishService dishService)
        {
            _logger = logger;
            _dishService = dishService;
        }

        public void OnGet()
        {
            allDishes = _dishService.GetAll();
        }
    }
}
