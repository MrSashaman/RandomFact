using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace RandomFact.Pages;

public class RandomName : PageModel
{
    private readonly List<string> _names = new()
    {
        "Александр", "Олег", "Мирослав", "Ленин", "Витя", "Платон", "Алексей"
    };

    private readonly Random _random = new();

    [BindProperty]
    public string CurrentName { get; set; } = string.Empty;

    public string GetRandomName()
    {
        int randomIndex = _random.Next(_names.Count);
        return _names[randomIndex];
    }

    public void OnGet()
    {
        CurrentName = GetRandomName();
    }

    public void OnPost()
    {
        CurrentName = GetRandomName();
        Console.WriteLine(CurrentName);
    }
}
