using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using СalculatSuppliers.Models;

namespace СalculatSuppliers.Pages
{
    public class SignInModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public User user { get; set; }

        public string Message { get; set; }

        public bool IsAuthorization { get; set; }

        public void OnGet()
        {

        }
        public void OnPost()
        {
            IsAuthorization = true;
            if(user.Login == null && user.Password == null)
                IsAuthorization = false;
        }
    }
}