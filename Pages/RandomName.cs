using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace RandomFact.Pages;

public class RandomName : PageModel
{
private readonly List<string> _names = new()
{
    "Александр", "Олег", "Мирослав", "Витя", "Платон", "Алексей",
    "Иван", "Дмитрий", "Сергей", "Андрей", "Николай",
    "Михаил", "Владимир", "Василий", "Павел", "Егор",
    "Константин", "Юрий", "Борис", "Григорий", "Фёдор",
    "Степан", "Антон", "Максим", "Виктор", "Валерий",
    "John", "James", "Michael", "William", "Robert",
    "David", "Richard", "Thomas", "Joseph", "Charles",
    "Daniel", "Matthew", "Christopher", "Andrew", "Anthony",
    "George", "Benjamin", "Samuel", "Jack", "Henry",
    "Hans", "Fritz", "Karl", "Wilhelm", "Otto",
    "Heinrich", "Erich", "Rudolf", "Klaus", "Wolfgang",
    "Gustav", "Friedrich", "Johann", "Ludwig", "Walter",
    "Werner", "Helmut", "Gerhard", "Konrad", "Dieter",
    "Ленин", "Иосиф", "Карл", "Фридрих", "Энгельс",
    "Маркс", "Лев", "Троцкий", "Мао", "Эрнесто",
    "Фидель", "Хо", "Димитров", "Че", "Ким",
    "Владлен", "Нинель", "Мэлс", "Ким", "Рэм",
    "Октябрин", "Октябрина", "Вилен", "Марлен", "Даздраперм"
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
