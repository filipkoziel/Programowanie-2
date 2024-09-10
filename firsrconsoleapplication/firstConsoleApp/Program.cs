// See https://aka.ms/new-console-template for more information
Console.Write("Hello, World!");
Console.Write("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");

string name = "Jan";   
string surname = "Kowalski";
Console.WriteLine("witaj " + name + " " + surname + " tutaj!!!");
Console.WriteLine("witaj {0} {1} tutaj!!!", name, surname);
Console.WriteLine($"witaj {name} {surname} tutaj!!!");

Console.WriteLine("Prędkość to km\\h");
Console.WriteLine(@"Prędkość to km\h");

int number = 5;
int secondNumber = 6;
Console.WriteLine($"number = {number}");
Console.WriteLine($"number = {secondNumber}");

void ParameterTest_v1(int p)
{
    p++;
    Console.WriteLine($"ParameterTest_v1: p = {p}");
}
void ParameterTest_v2(ref int p)
{
    p++;
    Console.WriteLine($"ParameterTest_v2: p = {p}");
}
ParameterTest_v1(number);
Console.WriteLine($"number = {number}");

ParameterTest_v2(ref number);
Console.WriteLine($"number = {number}");