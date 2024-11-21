
using LinqTasksConsoleApp;

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


// Zadanie 6: Znalezienie nazw zakończonych zadań posortowanych według długości nazwy


//Zadanie 7: Zadania pogrupowane według stanu zakończenia, a następnie posortowane w grupach według nazwy


//Zadanie 8: Najkrótsza nazwa zadania niezakończonego


//Zadanie 9: Ilość liter w nazwach wszystkich zakończonych zadań


//Zadanie 10: Lista zadań z indeksami (zakończone zadania z numeracją)

