using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWebDemo.Model;

namespace RazorWebDemo.Pages.Categories
{
    public class CreateModel : PageModel
    {
        public Category Category { get; set; }
        public void OnGet()
        {
        }
    }
}
