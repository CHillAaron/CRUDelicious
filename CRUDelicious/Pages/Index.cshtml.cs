using CRUDelicious.CORE;
using CRUDelicious.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDelicious.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly DishService _dishService;

        public List<Dishes> allDishes = new List<Dishes>();

        public IndexModel(ILogger<IndexModel> logger, DishService dishService)
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
