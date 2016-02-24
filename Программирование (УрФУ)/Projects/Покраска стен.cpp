#include <stdio.h>
#include <iostream>

using namespace std;

struct Distance
{
	int feet;
	float inches;
};

struct Room
{
	Distance x;
	Distance y;
	Distance z;  //x- ширина, y- высота, z- длина.
};

void vvod(int i, Room* box);
Distance sum(Room *box, int i);
Distance sum1(Room *box, int i);

int main()
{
	setlocale(LC_CTYPE, "Russian");
	int i;
	cout << "Введите количество комнат, которые вы хотите перекрасить в новый цвет:" << endl;
	cin >> i;
	Room* box = new Room[i];
	vvod(i, box);
	Distance S = sum(box, i), Pol = sum1(box, i);
	cout << "Общая площадь стен будет " << S.feet << " футов " << S.inches << "дюймов" << endl;
	cout << "И общая площадь пола составляет " << Pol.feet << " футов " << Pol.inches << "дюймов" << endl;
	delete []box;
	system ("pause");
	return 0;
}


void vvod (int i, Room* box)
{
	int j;
	for(j=0; j<i; j++)
    {
		int numkomn = j+1;
        cin.sync();
        cout << "Введите ширину " << numkomn << " комнаты в футах: " << endl;
		cin >> box[j].x.feet;
		cout << " И дюймов: " << endl;
		cin >> box[j].x.inches;
        cout << "Введите высоту " << numkomn << " комнаты в футах: " << endl;
		cin>>box[j].y.feet;
		cout << " И дюймов: " << endl;
		cin>>box[j].y.inches;
        cout << "Введите длину " << numkomn << " комнаты  в футах: " << endl;
		cin >> box[j].z.feet;
		cout << " И дюймов: " << endl;
		cin >> box[j].z.inches;
		cout << endl;
    }
}

Distance sum(Room *box, int i)
{
	Distance S;
	for(int j=0; j<i; j++)
	{
		float plst = 2 * (box[j].y.feet) * (box[j].x.feet + box[j].z.feet );
		S.feet +=plst;
	}
	for(int j=0; j<i; j++)
	{
		float plst = 2 * ( box[j].y.inches/144) * ( box[j].x.inches/144 + box[j].z.inches/144);
		S.feet +=plst;
	}
	return S;
}

Distance sum1(Room *box, int i)
{
	Distance Pol;
	for(int j=0; j<i; j++)
	{
		float plpol = (box[j].x.feet) * (box[j].z.feet );
		Pol.feet +=plpol;
	}
	for(int j=0; j<i; j++)
	{
		float plpol = (box[j].x.inches/144) * ( box[j].z.inches/144);
		Pol.inches +=plpol;
	}
	return Pol;
}
