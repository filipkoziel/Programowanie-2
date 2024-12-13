
using LinqTasksConsoleApp;
using System;

var tasks = new List<TaskItem>
{
    new TaskItem(1, "Buy groceries", true),
    new TaskItem(2, "Clean the house", false),
    new TaskItem(3, "Pay bills", true),
    new TaskItem(4, "Study LINQ", false),
    new TaskItem(5, "Exercise", true)
};

// Zadanie 1: Wyszukaj wszystkie zakończone zadania
Console.WriteLine("Zadanie 1");
Console.WriteLine("Zakończone zadania:");

List<TaskItem> completedTasks = tasks.Where(n => n.IsCompleted == true).ToList();
foreach (var task in completedTasks)
{
    Console.WriteLine(task);
}

// Zadanie 2: Znajdź pierwsze zadanie, które nie jest zakończone

Console.WriteLine("Zadanie 2");
Console.WriteLine("Pierwsze niezakończone zadanie:");
TaskItem firstNotCompleted = tasks.First(n => n.IsCompleted == false);
Console.WriteLine(firstNotCompleted);

// Zadanie 3: Posortuj zadania według nazwy

Console.WriteLine("Zadanie 3");
Console.WriteLine("Zadania posortowane po nazwie:");
List<TaskItem> sortedTasks = tasks.OrderBy(n => n.Name).ToList();
foreach (var task in sortedTasks)
{
    Console.WriteLine(task);
}

// Zadanie 4: Policz zadania zakończone
Console.WriteLine("Zadanie 4");
Console.WriteLine("Liczba zakończonych zadań:");

int zakończone = tasks.Where(n => n.IsCompleted == true).Count();
Console.WriteLine(zakończone);

// Zadanie 5: Wybierz tylko nazwy zadań i wyświetl
Console.WriteLine("Zadanie 5");
Console.WriteLine("Zadania posortowane po nazwie:");

List<string> zadania = tasks.Select(n => n.Name).ToList();
foreach (var task in zadania)
{
    Console.WriteLine(task);
}

// Zadanie 6: Znalezienie nazw zakończonych zadań posortowanych według długości nazwy
Console.WriteLine("Zadanie 6");
Console.WriteLine("Zadania posortowane po nazwie:");

List<TaskItem> sortedCompletedTasks = tasks.Where(n => n.IsCompleted == true).OrderBy(n => n.Name.Length).ToList();
foreach (var task in sortedCompletedTasks)
{
    Console.WriteLine(task);
}

//Zadanie 7: Zadania pogrupowane według stanu zakończenia, a następnie posortowane w grupach według nazwy
Console.WriteLine("Zadanie 7");
Console.WriteLine("Zadania pogrupowane po stanie zakończenia, i grupy posortowane po nazwie:");

var groupByCompleted = tasks.GroupBy(n => n.IsCompleted);
foreach (var task in groupByCompleted)
{
    var sortGroupsByName = task.OrderBy(n => n.Name).ToList();
    foreach (var p in sortGroupsByName)
    {
        Console.WriteLine(p);
    }
}

//Zadanie 8: Najkrótsza nazwa zadania niezakończonego
Console.WriteLine("Zadanie 8");
Console.WriteLine("Najkrótsza nazwa zadania niezakończonego:");

string shortestNameOfUncompletedTask = tasks.Where(n => !n.IsCompleted).OrderBy(n => n.Name.Length).Select(n => n.Name).FirstOrDefault();
Console.WriteLine(shortestNameOfUncompletedTask);

//Zadanie 9: Ilość liter w nazwach wszystkich zakończonych zadań
Console.WriteLine("Zadanie 9");
Console.WriteLine("Suma ilości liter w wszystkich zakończonych zadania:");

int numberOfLettersInCompletedTasks = tasks.Where(n => n.IsCompleted).Select(n => n.Name.Length).Sum();
Console.WriteLine(numberOfLettersInCompletedTasks);

//Zadanie 10: Lista zadań z indeksami (zakończone zadania z numeracją)

Console.WriteLine("Zadanie 10");
//var x = tasks.Where(n => n.IsCompleted);
//for (int i = 0; i < x.Count(); i++)
//{
//    Console.WriteLine($"{i + 1}:");
//    Console.WriteLine(x.ElementAt(i));
//}

//List<Result> completedTasksWithIndex = tasks.Where(n => n.IsCompleted).Select((t, Index) => new Result() { Index = Index+1, Task = t}).ToList();
//foreach (Result r in completedTasksWithIndex)
//{
//    Console.WriteLine(r.Index);
//    Console.WriteLine(r.Task);
//}

//class Result
//{
//    public int Index { get; set; }
//    public TaskItem Task { get; set; }
//}

var completedTasksWithIndex = tasks.Where(n => n.IsCompleted)
    .Select((t, Index) => new { Index = Index + 1, Task = t })
    .ToList();

foreach (var r in completedTasksWithIndex)
{
    Console.WriteLine(r.Index);
    Console.WriteLine(r.Task);
}

//Zadanie 11: Zadania z najdłuższą nazwą w każdej grupie zakończonych i niezakończonych

var groupByCompletedAgain = tasks.GroupBy(n => n.IsCompleted);
Console.WriteLine("Zadanie 11");
Console.WriteLine("Zadania z najdłuższą nazwą w każdej grupie zakończonych i niezakończonych:");

foreach (var group in groupByCompletedAgain)
{
    Console.WriteLine($"Grupa zakończona: {group.Key}");
    var maxName = group.OrderByDescending(n => n.Name.Length).First().Name;
    Console.WriteLine($"Najdłusza nazwa w grupie: {maxName}");
}

//Zadanie 12: Zlicz, ile zadań w każdej grupie zakończonych i niezakończonych zawiera słowo „the” w nazwie
Console.WriteLine("Zadanie 12");
Console.WriteLine("Zlicz, ile zadań w każdej grupie zakończonych i niezakończonych zawiera słowo „the” w nazwie:");

var groupByCompletedAgainAgain = tasks.GroupBy(n => n.IsCompleted);
foreach (var group in groupByCompletedAgainAgain)
{
    Console.WriteLine($"Grupa zakończona: {group.Key}");
    var countThe = group.Where(n => n.Name.Contains(" the ")).Count();
    Console.WriteLine($"Ile zadań w grupie zawiera 'the': {countThe}");
}


//Zadanie 13: Utwórz listę zakończonych zadań z ich numeracją oraz długością nazw
Console.WriteLine("Zadanie 13");
Console.WriteLine("Utwórz listę zakończonych zadań z ich numeracją oraz długością nazw:");

var completedAgain = tasks
    .Where(n => n.IsCompleted)
    .Select(n => new { Id = n.Id, Name = n.Name.Length });
foreach (var column in completedAgain)
{
    Console.WriteLine($"{column.Id} - {column.Name}");
}

//Zadanie 14: Zadania posortowane według stanu zakończenia, a następnie alfabetycznie według nazw
Console.WriteLine("Zadanie 14");
Console.WriteLine("Zadania posortowane według stanu zakończenia, a następnie alfabetycznie według nazw:");

List<TaskItem> sortedTasksByCompletedThenName = tasks.OrderBy(n => n.IsCompleted).ThenBy(n => n.Name).ToList();
foreach (var column in sortedTasksByCompletedThenName)
{
    Console.WriteLine(column);
}

//Zadanie 15: Sprawdź, czy w nazwach wszystkich zadań są co najmniej 2 różne samogłoski
Console.WriteLine("Zadanie 15");
Console.WriteLine("Sprawdź, czy w nazwach wszystkich zadań są co najmniej 2 różne samogłoski:");

var x = tasks.All(n => n.Name.ToLower().Where(n => "aeiou".Contains(n)).Distinct().Count() >= 2);
Console.WriteLine(x);

//Zadanie 16: Znajdź wszystkie unikalne litery używane w nazwach zadań zakończonych
Console.WriteLine("Zadanie 16");
Console.WriteLine("Znajdź wszystkie unikalne litery używane w nazwach zadań zakończonych:");

var letter = tasks.Where(n => n.IsCompleted).SelectMany(n => n.Name.ToLower().Where(c => char.IsLetter(c))).Distinct();

Console.WriteLine(string.Join(",",letter));