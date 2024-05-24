#include <iostream>
#include <string>
#include <ctime>


using namespace std;

class Count
{
private:
    double value;

public:
    Count()
    {
        value = 0;
    }

    Count(int startingValue)
    {
        value = startingValue;
    }

    void Add(int addedNumber)
    {
        value = value + addedNumber;
    }

    void Subtract(int subtractedNumber)
    {
        value = value - subtractedNumber;
    }
};

class Adder
{
private:
    int numbers[100];

public:
    Adder()
    {
        for (int i = 0; i < 100; i++)
        {
            numbers[i] = 0;
        }
    }

    Adder(int maxNumber)
    {
        for (int i = 0; i < 100; i++)
        {
            numbers[i] = (rand() % (maxNumber + 1));
        }
    }

    int Sum()
    {
        int sum = 0;
        for (int i = 0; i < 100; i++)
        {
            sum = sum + numbers[i];
        }
        return sum;
    }

    double SumDividedBy3()
    {
        double sum = 0;
        for (int i = 0; i < 100; i++)
        {
            sum = sum + numbers[i];
        }
        sum = sum / 3;
        return sum;
    }

    void WriteNumbers()
    {
        for (int i = 0; i < 100; i++)
        {
            cout << numbers[i] << " ";
        }
        cout << "\n\n";
    }

    void WriteNumbersFromMinAndMaxIndex(int lowIndex, int highIndex)
    {
        for (int i = 0; i < 100; i++)
        {
            if (i >= lowIndex && i <= highIndex)
            cout << numbers[i] << " ";
        }
        cout << "\n\n";
    }
};

class Person 
{
private:
    string firstName;
    string surname;
    int age;

public:
    Person()
    {
        firstName = "";
        surname = "";
        age = 0;
    }

    Person(string a, string b, int c)
    {
        firstName = a;
        surname = b;
        age = c;
    }

    void Write()
    {
        cout << firstName << " " << surname << "\n" << age << "\n";
    }

};

class Book
{
private:
    string title;
    Person author;
    int published;

public:
    Book(string a, Person b, int c)
    {
        title = a;
        author = b;
        published = c;
    }

    void Write()
    {
        cout << title << "\n"; 
        author.Write();
        cout << published << "\n";
    }
};

class Date
{
private:
    time_t date = time(NULL);
    char buffer[26];

public:
    string ReturnLocalTime()
    {
        ctime_s(buffer, sizeof(buffer), &date);
        return buffer;
    }

    string ReturnTimeForwardWeek()
    {
        //nie wiem
    }

    string ReturnTimeBackwardWeek()
    {
        //nie wiem
    }

};

int main()
{
    // zadanie 1

    cout << "zadanie 1\n";

    Count countA, countB(5), countC(16);

    countA.Add(12);

    countB.Subtract(4);
    countB.Add(403);

    countC.Add(4);
    countC.Subtract(20);

    // zadanie 2

    cout << "\n\nzadanie 2\n";

    Adder addA, addB(12);

    cout << addA.Sum() << "\n\n";
    cout << addA.SumDividedBy3() << "\n\n";
    addA.WriteNumbers();
    addA.WriteNumbersFromMinAndMaxIndex(5, 12);

    cout << addB.Sum() << "\n\n";
    cout << addB.SumDividedBy3() << "\n\n";
    addB.WriteNumbers();
    addB.WriteNumbersFromMinAndMaxIndex(5, 12);

    // zadanie 3

    cout << "\n\nzadanie 3\n";

    Person a("filip", "kozie³", 16);

    a.Write();


    Person author("Antoine", "de Saint-Exupéry", 44);
    Book b("ma³y ksi¹¿e", author, 1943);

    b.Write();

    // zadanie 4

    cout << "\n\n zadanie 4\n";

    Date localTime;
    cout << localTime.ReturnLocalTime();


}

