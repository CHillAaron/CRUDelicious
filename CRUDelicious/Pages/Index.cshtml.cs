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
        private readonly ChefService _chefService;

        public List<Chef> allChefs = new List<Chef>();

        public IndexModel(ILogger<IndexModel> logger, ChefService chefService)
        {
            _logger = logger;
            _chefService = chefService;
        }

        public void OnGet()
        {
            allChefs = _chefService.GetAll();
        }
    }
}
