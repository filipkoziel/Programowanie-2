#include <iostream>

using namespace std;

/*
* Napisz program, który bêdzie prosi³ o has³o. Nie przepuœci dalej dopóki nie zostanie ono podane prawid³owo.
* Napisz program, który pobiera od u¿ytkownika ci¹g znaków i wyœwietla liczbê samog³osek i spó³g³osek w tym ci¹gu.
* Poproœ u¿ytkownika o wprowadzenie liczby ca³kowitej w systemie dziesiêtnym. Nastêpnie skonwertuj tê liczbê na system dwójkowy (binarny) i wyœwietl wynik.
* Program sprawdzaj¹cy czy podany ci¹g znaków jest palindromem (czyli takim, który czytany od ty³u jest taki sam, jak czytany od przodu, np. "kajak")
* Program sprawdzaj¹cy czy podane dwa s³owa s¹ anagramami (czyli takimi, które zawieraj¹ te same litery, ale w innym uk³adzie, np. "klasa" i "salka")
*

* Program wyci¹gaj¹cy informacje z numeru PESEL
* Program implementuj¹cy algorytm szyfrowania Cezara (proste szyfrowanie, w którym ka¿dy znak w tekœcie jest zastêpowany innym znakiem, przesuniêtym o sta³¹ liczbê pozycji w alfabecie).


* Program który na wejœciu przyjmie równanie a na wyjœciu da równanie w odwrotnej notacji polskiej ONP. Np. na wejœciu 2+3*4 na wyjœcu da 234*+
* Program, który na wejœciu przyjmie rówanie w ONP a na wyjœciu wyœwietli wynik rówania.
*/

void task1()
{
	char characterFromUser;
	cout << "Podaj znak\n";
	cin >> characterFromUser;

	if (characterFromUser >= 94 && characterFromUser <= 122)
		cout << "tak\n";
	else
		cout << "nie\n";

}

void task2()
{
	string nameFromUser;

	cout << "Input your name!!!\n";
	cin >> nameFromUser;

	cout << "Hello " << nameFromUser << "! How are you?";

}

void task3()
{
	string textFromUser;
	cout << "podaj tekst\n";
	cin >> textFromUser;
	
	int counter = 0;

	for (int i = 0; i < textFromUser.length() ; i++)
	{
		if (textFromUser[i] == 'a')
		{
			counter++;
		}
		
	}
	cout << counter << "\n";
}

//Napisz program, który bêdzie prosi³ o has³o. Nie przepuœci dalej dopóki nie zostanie ono podane prawid³owo.
void task1Zadania()
{
	string password = "SUPERSECUREPASSWORD";
	string attempt;

	cout << "Input password!\n";
	cin >> attempt;

	for (int i = 0; i == 0;)
	{
		if (password == attempt)
		{
			cout << "HOW DID YOU KNOW!\n";
			i++;
		}
		else
		{
			cout << "WRONG!! YOU CAN TRY AGAIN.\n";
		}
	}
}

//
void task2Zadania

int main()
{
	task1Zadania();
}
