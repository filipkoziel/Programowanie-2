using EgzaminINF042026;
int numberGiven = Int32.Parse(Console.ReadLine());

Kosc kosc1 = new Kosc(numberGiven);

Console.WriteLine($"liczba utworzonych instancji klasy Kosc: {Kosc.NumberOfDice}");
Console.WriteLine($"liczba wyrzuconych oczek: {kosc1.numberThrown}");
Console.WriteLine($"nazwa pliku odpowiadającego wyrzuconej liczbie oczek: {kosc1.imageNames[kosc1.imageFileIdentifier]}");


Kosc kosc2 = new Kosc();

Console.WriteLine($"liczba utworzonych instancji klasy Kosc: {Kosc.NumberOfDice}");
Console.WriteLine($"liczba wyrzuconych oczek: {kosc2.numberThrown}");
Console.WriteLine($"nazwa pliku odpowiadającego wyrzuconej liczbie oczek: {kosc2.imageNames[kosc2.imageFileIdentifier]}");