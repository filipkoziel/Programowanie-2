#include <iostream>

using namespace std;

class Board
{
private:
    int size = 8;
    char board[64];

public:
    Board()
    {
        for (int i = 0; i < 64; i++)
        {
            if (i == 0 || i == 7 || i == 56 || i == 63)
            {
                board[i] = 'T';
            }
            else if (i == 1 || i == 6 || i == 57 || i == 62)
            {
                board[i] = 'H';
            }
            else if (i == 2 || i == 5 || i == 58 || i == 61)
            {
                board[i] = 'B';
            }
            else if (i == 3 || i == 59)
            {
                board[i] = 'K';
            }
            else if (i == 4 || i == 60)
            {
                board[i] = 'Q';
            }
            else if (i > 7 && i < 16 || i < 56 && i > 47)
            {
                board[i] = 'P';
            }
            else
            {
                board[i] = ' ';
            }
        }
    }


    void BuildBoard()
    {
        for (int i = 0; i < 64; i++)
        {
            if (i != 0 && i % 8 == 0)
            {
                cout << " |\n";
                Buildrow();
                cout << "\n";
            }
            cout << " | " << board[i];
        }
        cout << " |";
    }

    void Buildrow()
    {
        cout << " ";
        for (int i = 0; i < 33; i++)
        {
            cout << "=";
        }
    }
};



int main()
{
    Board b;
    b.BuildBoard();
}

