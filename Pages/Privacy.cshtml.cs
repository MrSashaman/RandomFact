using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RandomFact.Pages;

public class PrivacyModel : PageModel
{
    public int daysPassed { get; set; }
    private readonly ILogger<PrivacyModel> _logger;

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        daysPassed = Time.TimeCreation();
        
        Console.WriteLine(daysPassed);
    }
}

