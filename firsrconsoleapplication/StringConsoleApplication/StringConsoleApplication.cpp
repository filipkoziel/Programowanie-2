#include <iostream>

using namespace std;

/*
* Napisz program, kt�ry b�dzie prosi� o has�o. Nie przepu�ci dalej dop�ki nie zostanie ono podane prawid�owo.
* Napisz program, kt�ry pobiera od u�ytkownika ci�g znak�w i wy�wietla liczb� samog�osek i sp�g�osek w tym ci�gu.
* Popro� u�ytkownika o wprowadzenie liczby ca�kowitej w systemie dziesi�tnym. Nast�pnie skonwertuj t� liczb� na system dw�jkowy (binarny) i wy�wietl wynik.
* Program sprawdzaj�cy czy podany ci�g znak�w jest palindromem (czyli takim, kt�ry czytany od ty�u jest taki sam, jak czytany od przodu, np. "kajak")
* Program sprawdzaj�cy czy podane dwa s�owa s� anagramami (czyli takimi, kt�re zawieraj� te same litery, ale w innym uk�adzie, np. "klasa" i "salka")
*

* Program wyci�gaj�cy informacje z numeru PESEL
* Program implementuj�cy algorytm szyfrowania Cezara (proste szyfrowanie, w kt�rym ka�dy znak w tek�cie jest zast�powany innym znakiem, przesuni�tym o sta�� liczb� pozycji w alfabecie).


* Program kt�ry na wej�ciu przyjmie r�wnanie a na wyj�ciu da r�wnanie w odwrotnej notacji polskiej ONP. Np. na wej�ciu 2+3*4 na wyj�cu da 234*+
* Program, kt�ry na wej�ciu przyjmie r�wanie w ONP a na wyj�ciu wy�wietli wynik r�wania.
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

//Napisz program, kt�ry b�dzie prosi� o has�o. Nie przepu�ci dalej dop�ki nie zostanie ono podane prawid�owo.
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
