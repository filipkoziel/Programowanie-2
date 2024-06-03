#include <iostream>

using namespace std;

class Board
{
private:
    int size = 8;
    Chesspiece board[64];

public:
    Board()
    {
        for (int i = 0; i < 64; i++)
        {
            if (i == 0 || i == 7 || i == 56 || i == 63)
            {
                board[i] = { i, 'T', 'W' };
            }
            else if (i == 1 || i == 6 || i == 57 || i == 62)
            {
                board[i] = { i, 'H', 'W' };
            }
            else if (i == 2 || i == 5 || i == 58 || i == 61)
            {
                board[i] = { i, 'B', 'W' };
            }
            else if (i == 3 || i == 59)
            {
                board[i] = { i, 'K', 'W' };
            }
            else if (i == 4 || i == 60)
            {
                board[i] = { i, 'Q', 'W' };
            }
            else if (i > 7 && i < 16 || i < 56 && i > 47)
            {
                board[i] = { i, 'P', 'W' };
            }
            else
            {
                board[i] = { i, ' ', 'W' };
            }
        }
    }


    void BuildBoard()
    {
        for (int i = 0; i < 64; i++)
        {
            if (i != 0 && i % 8 == 0)
                Buildrow();

            Buildcol(i);
        }
        cout << " |";
    }

    void Buildcol(int i)
    {
            cout << " | " << board[i].GetSign();
    }

    void Buildrow()
    {
        cout << " |\n ";
        for (int i = 0; i < 33; i++)
        {
            cout << "=";
        }
        cout << "\n";
    }

    bool Checkspace(int position, char curentType)
    {
        //if (curentType =
        //return board[position];
    }
};

class Chesspiece 
{
protected:
    int position;
    char piece;
    char type;

public:

    Chesspiece()
    {
        position = 65;
        piece = 'O';
        type = 'R';
    }

    Chesspiece(int number, char sign, char color)
    {
        position = number;
        piece = sign;
        type = color;
    }

    void select(int position, char piece)
    {

    }

    char GetSign()
    {
        return piece;
    }
};

class Tower : public Chesspiece
{
private:

public:
    void Move(int place, Board b, char currentType)
    {
        if (b.Checkspace(place, currentType))
        {

        }
    }
};

int main()
{
    Board b;
    b.BuildBoard();
}

