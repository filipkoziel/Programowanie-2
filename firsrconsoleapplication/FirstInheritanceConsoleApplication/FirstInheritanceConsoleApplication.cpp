 #include <iostream>

using namespace std;

class C
{
protected:
    int fieldA;
    string name;

public:

    C()
    {
        fieldA = 15;
        name = "C";
    }

    C(int a, string n)
    {
        fieldA = a;
        name = n;
    }

    int GetFieldA()
    {
        return fieldA;
    }

    void ShowInfo()
    {
        cout << "Informacja na temat klasy "<< name <<"\n";
        cout << "Field A = " << fieldA << "\n";
    }
};

class A : public C
{
private:

public:
    A():C(5, "A")
    {

    }

    /*
        void ShowInfo()
    {
        cout << "Informacja na temat klasy A\n";
        cout << "Field A = " << fieldA << "\n";
    }
    */
};

class B : public C
{
private:
    //int fieldA;
    int fieldB;

public:
    B(): C(10, "B")
    {
        fieldB = 4;
    }

    /*int GetFieldA()
    {
        return fieldA;
    }*/

    int GetFieldB()
    {
        return fieldB;
    }

    
    void ShowInfo()
    {
        C::ShowInfo();
        cout << "Field B = " << fieldB << "\n";
    }

};

int main()
{
    A a;
    a.ShowInfo();

    B b;
    b.ShowInfo();

    C c;
    c.ShowInfo();
}