using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace RandomFact.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public string CurrentFact { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }


    public void OnPost()
    {
        var service = new FactService();
        CurrentFact = service.GetRandomFact();
        Console.WriteLine(CurrentFact);
    }


}
