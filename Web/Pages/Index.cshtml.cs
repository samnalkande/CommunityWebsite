using System;
using System.Globalization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace de.tbdev.CommunityWebsite.Web.Pages
{
    public class IndexModel : PageModel
    {
        public string CustomHelloString { get; set; }
        
        public void OnGet()
        {
            CustomHelloString = DateTime.Now.ToString(CultureInfo.GetCultureInfo("de-DE"));
        }
    }
}