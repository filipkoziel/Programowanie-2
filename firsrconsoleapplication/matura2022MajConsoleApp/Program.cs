// zadanie 4

StreamReader steamreader = new StreamReader("przyklad.txt");

string strNumberFromFile;
List<string> strNumbers = new List<string>();

while ((strNumberFromFile = steamreader.ReadLine()) != null)
{
    strNumbers.Add(strNumberFromFile);
}

steamreader.Close();

// zadanie 4.1

int counter4_1 = strNumbers.Where(s => s[0] == s[s.Length - 1]).Count();
string firstNumber4_1 = strNumbers.First(s => s[0] == s[s.Length - 1]);
Console.WriteLine($"{counter4_1} {firstNumber4_1}");

// zadanie 4.2
int divider = 2;

foreach(string number in strNumbers)
{
    while(divider > 1)
    if (Convert.ToInt32(number) % divider == 0)
    { 
        
    }
}

int counter4_2 = 