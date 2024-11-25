
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

List<TaskItem> completedTasks = tasks.Where(n => n.IsCompleted == true).ToList();
Console.WriteLine("Zadanie 1");
Console.WriteLine("Zakończone zadania:");
foreach (var task in completedTasks)
{
    Console.WriteLine(task);
}

// Zadanie 2: Znajdź pierwsze zadanie, które nie jest zakończone

TaskItem firstNotCompleted = tasks.First(n => n.IsCompleted == false);
Console.WriteLine("Zadanie 2");
Console.WriteLine("Pierwsze niezakończone zadanie:");
Console.WriteLine(firstNotCompleted);

// Zadanie 3: Posortuj zadania według nazwy

List<TaskItem> sortedTasks = tasks.OrderBy(n => n.Name).ToList();
Console.WriteLine("Zadanie 3");
Console.WriteLine($"Zadania posortowane po nazwie:");
foreach (var task in sortedTasks)
{
    Console.WriteLine(task);
}

// Zadanie 4: Policz zadania zakończone

int zakończone = tasks.Where(n => n.IsCompleted == true).Count();
Console.WriteLine("Zadanie 4");
Console.WriteLine($"Liczba zakończonych zadań: {zakończone}");

// Zadanie 5: Wybierz tylko nazwy zadań i wyświetl

List<string> zadania = tasks.Select(n => n.Name).ToList();
Console.WriteLine("Zadanie 5");
Console.WriteLine($"Zadania posortowane po nazwie:");
foreach (var task in zadania)
{
    Console.WriteLine(task);
}

// Zadanie 6: Znalezienie nazw zakończonych zadań posortowanych według długości nazwy

List<TaskItem> sortedCompletedTasks = tasks.Where(n => n.IsCompleted == true).OrderBy(n => n.Name.Length).ToList();
Console.WriteLine("Zadanie 6");
Console.WriteLine($"Zadania posortowane po nazwie:");
foreach (var task in sortedCompletedTasks)
{
    Console.WriteLine(task);
}

//Zadanie 7: Zadania pogrupowane według stanu zakończenia, a następnie posortowane w grupach według nazwy

var groupByCompleted = tasks.GroupBy(n => n.IsCompleted);
Console.WriteLine("Zadanie 7");
Console.WriteLine($"Zadania pogrupowane po stanie zakończenia, i grupy posortowane po nazwie:");
foreach (var task in groupByCompleted)
{
    var sortGroupsByName = task.OrderBy(n => n.Name).ToList();
    foreach (var p in sortGroupsByName)
    {
        Console.WriteLine(p);
    }
}

//Zadanie 8: Najkrótsza nazwa zadania niezakończonego

string shortestNameOfUncompletedTask = tasks.Where(n => !n.IsCompleted).OrderBy(n => n.Name.Length).Select(n => n.Name).FirstOrDefault();
Console.WriteLine("Zadanie 8");
Console.WriteLine($"Najkrótsza nazwa zadania niezakończonego:");
Console.WriteLine(shortestNameOfUncompletedTask);

//Zadanie 9: Ilość liter w nazwach wszystkich zakończonych zadań

int numberOfLettersInCompletedTasks = tasks.Where(n => n.IsCompleted).Select(n => n.Name.Length).Sum();
Console.WriteLine("Zadanie 9");
Console.WriteLine($"Suma ilości liter w wszystkich zakończonych zadania:");
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
    .Select((t, Index) => new { Index = Index + 1, Task = t, Kolejny = 5})
    .ToList();

foreach (var r in completedTasksWithIndex)
{
    Console.WriteLine(r.Index);
    Console.WriteLine(r.Task);
}

//Zadanie 11: Zadania z najdłuższą nazwą w każdej grupie zakończonych i niezakończonych
//Zadanie 12: Zlicz, ile zadań w każdej grupie zawiera słowo „the” w nazwie
//Zadanie 13: Utwórz listę zakończonych zadań z ich numeracją oraz długością nazw
//Zadanie 14: Zadania posortowane według stanu zakończenia, a następnie alfabetycznie według nazw
//Zadanie 15: Sprawdź, czy w nazwach wszystkich zadań są co najmniej 2 różne samogłoski
//Zadanie 16: Znajdź wszystkie unikalne litery używane w nazwach zadań zakończonych