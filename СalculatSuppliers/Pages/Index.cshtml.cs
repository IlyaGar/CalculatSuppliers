﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using СalculatSuppliers.Models;

namespace СalculatSuppliers.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public FilterDocument filter { get; set; }

        public void OnGet()
        {

        }
        public void OnPost()
        {

        }
    }
}