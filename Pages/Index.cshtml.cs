using FizzBuzzWeb.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FizzBuzzWeb.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    [BindProperty]
    public FizzBuzzForm FizzBuzz { set; get; }
    [BindProperty(SupportsGet = true)]
    public string Name { get; set; }
    public string cobet {get; set;}

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        if (string.IsNullOrWhiteSpace(Name))
        {
            Name = "User";
        }
    }

    public IActionResult OnPost()
    {
        if (ModelState.IsValid)
        {
            cobet = "";
            if (FizzBuzz.Number % 3 == 0) {
                cobet = "Fizz";
            }
            if (FizzBuzz.Number % 5 == 0) {
                cobet += "Buzz";
            }
            if (cobet == "" || FizzBuzz.Number == 0) {
                cobet = "Liczba " + FizzBuzz.Number + " nie spelnia kryteriow FizzBuzz";
            }
            return Page();
        }
        return RedirectToPage("./Privacy");
    }

}
