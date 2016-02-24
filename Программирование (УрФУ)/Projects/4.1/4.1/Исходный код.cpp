#include <iostream>
#include <iomanip>
#include <cstdlib>
#include <cmath>
#include <string>
using namespace std;
 
class Squre
{
private:
	int size;
public:
	Squre()
	{}
	void vvod()
	{
		cout << "Длина стороны квадрата = ";
		cin >> size;
	}

	void drow()
	{
		for (int y = 1; y <= size; y++)
		{
        for (int x = 1; x <= size; x++)
        {
            cout << "* ";
        }
        cout << endl;
    }
	}

};

class Trigl
{
private:
	int size;
public:
	void vvod()
	{
		cout << endl << "Длина стороны треугольника = ";
		cin >> size;
	}
	void drow()
	{
		int h = (int)(size * 0.71);
		for (int y = 1; y <= h; y++) 
    {
        for (int x = 1; x < h * 2; x++)
        {
            if ( y <= h * 2 && y >= h - x + 1 && x <= y + h - 1)
                cout << "*";
            else
                cout << " ";
        }
        cout << endl;
    }
    cout << endl;
	}
};

class Circle
{
	private:
	int size;
public:
	void vvod()
	{
		cout << endl << "Радиус круга = ";
		cin >> size;
	}
	void drow()
	{
		string dr="*";
		for (int i=1; i<size; i++)
		{
			dr=(dr+dr);
			cout << setw(30)<< setiosflags(ios::fixed) << dr << endl;
		}

	}
};




int main()
{
	setlocale(LC_CTYPE, "Russian");
	Squre go;
	go.vvod();
	go.drow();
	Trigl go1;
	go1.vvod();
	go1.drow();
	Circle go2;
	go2.vvod();
	go2.drow();
	system ("pause");
return 0;
}