
// int[] intArray = new int[10];

using System.Reflection.Metadata.Ecma335;

List<int> intsCollecion = new List<int>();
intsCollecion.Add(15);
intsCollecion.Add(18);

Console.WriteLine(intsCollecion[0]);
Console.WriteLine(intsCollecion[1]);

intsCollecion.Add(5);

Console.WriteLine(intsCollecion[0]);
Console.WriteLine(intsCollecion[1]);
Console.WriteLine(intsCollecion[2]);

intsCollecion.RemoveAt(1);

Console.WriteLine(intsCollecion[0]);
Console.WriteLine(intsCollecion[1]);

intsCollecion.Add(12);
intsCollecion.Add(19);
intsCollecion.Add(4);

Console.WriteLine("elementy na kolekcji: ");
for (int i = 0; i < intsCollecion.Count; i++)
{
    Console.WriteLine(intsCollecion[i]);
}

List<int> intsGreat10Collection = new List<int>();

for  (int i = 0; i < intsCollecion.Count; i++)
{
    if (intsCollecion [i] > 10)
        intsGreat10Collection.Add(intsCollecion [i]);
}

Console.WriteLine("Elementy na kolekcji większych niż 10: ");
for (int i = 0; i < intsGreat10Collection.Count; i++)
{
    Console.WriteLine(intsGreat10Collection[i]);
}


List<int> intsFrom5To7Collection = new List<int>();

for (int i = 0; i < intsCollecion.Count; i++)
{
    if (intsCollecion[i] >= 5 && intsCollecion[i] <= 7)
        intsFrom5To7Collection.Add(intsCollecion[i]);
}

Console.WriteLine("Elementy na kolekcji pomiędzy 5 i 7: ");
for (int i = 0; i < intsFrom5To7Collection.Count; i++)
{
    Console.WriteLine(intsFrom5To7Collection[i]);
}

bool great10(int number)
{
    return number > 10;
}

Func<int, bool> great10s;
great10s = (i) => i > 10;

bool from5To7(int number)
{
    return number >= 5 && number <= 7;
}

bool even(int number)
{
    return number % 2 == 0;
}

List<int> FilterCollection(List<int> collection, Func<int, bool> check)
{
    List<int> returnCollection = new List<int>();

    for (int i = 0; i < collection.Count; i++)
    {
        if (check(collection[i]) == true)
            returnCollection.Add(collection[i]);
    }

    return returnCollection;
}

List<int> result1 = FilterCollection(intsCollecion, i => i > 10);
List<int> result2 = FilterCollection(intsCollecion, i => i >= 5 && i <= 7);
List<int> result3 = FilterCollection(intsCollecion, i => i % 2 == 0);

Func<int, bool> func1;
func1 = (int i) => { return i % 2 == 0; };