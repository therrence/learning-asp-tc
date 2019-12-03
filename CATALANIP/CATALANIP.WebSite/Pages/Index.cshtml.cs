﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CATALANIP.WebSite.Services;
using CATALANIP.WebSite.Models;

namespace CATALANIP.WebSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductService ProductService;
        public IEnumerable<Product> Products { get; private set; }


        public IndexModel
            (ILogger<IndexModel> logger,
            JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}
