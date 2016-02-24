#include <iostream>
#include <stdio.h>
#include <string>
#include <clocale>

using namespace std;

class Auto
{
protected:
	struct Coord
	{
		int x;
		int y;
	};
public:
	float V;
	Coord coordinates;
	float P;
	virtual void InPut(){
		cout << "\nВведите скорость автобуса(км/ч): ";
		cin >> V;
		cout << "Координаты X и Y (через пробел): ";
		cin >> coordinates.x >> coordinates.y;
		cout << "Введите мощность (л.c.): ";
		cin >> P;
	};
	virtual void OutPut(){
		cout << "\nСкорость транспортного средства" << V << " км/ч\nКоординаты: " << coordinates.x << ":" << coordinates.y << "\nМощность " << P << " л.с.\n";
	};
};

class Bus : public Auto
{
public:
	string Stop;
	float Price;
	void InPut()
	{
		Auto::InPut();
		cout << "Введите название остановки: ";
		cin >> Stop;
		cout << "Введите стоимос проезда: ";
		cin >> Price;
	}
	void OutPut()
	{
		Auto::OutPut();
		cout  << "\nНа остановке ''" << Stop << "''\nСтоимость проезда - " << Price << endl;
	}
	Bus()
	{
		InPut();
	}
	Bus(float speed, Auto::Coord loc, float p, string BusStop, float Pr)
	{
		V = speed;
		coordinates = loc;
		P = p;
		Stop = BusStop;
		Price = Pr;
	}
};

class Big : public Auto
{
public:
	float MaxMass;
	float Mass;
	void InPut()
	{
		Auto::InPut();
		cout << "Максимальная масса: ";
		cin >> MaxMass;
		cout << "Введите нынешнюю массу: ";
		cin >> Mass;
	}
	void OutPut()
	{
		Auto::OutPut();
		cout << "\nМасса: " << Mass << " из " << MaxMass << " разрешенных.\n";
	}
	Big()
	{
		InPut();
	}
	Big(float speed, Auto::Coord loc, float p, float mxm, float m)
	{
		V = speed;
		coordinates = loc;
		P = p;
		MaxMass = mxm;
		Mass = m;
	}
};

class Mini : public Auto
{
public:
	int SeatsNumber;
	void InPut()
	{
		Auto::InPut();
		cout << "Введите кол-во мест: ";
		cin >> SeatsNumber;
	}
	void OutPut()
	{
		Auto::OutPut();
		cout << "\nКоличеств мест - " << SeatsNumber << endl;
	}
	Mini()
	{
		InPut();
	}
	Mini(float speed, Auto::Coord loc, float p,int SsN)
	{
		V = speed;
		coordinates = loc;
		P = p;
		SeatsNumber = SsN;
	}
};

void main()
{
	setlocale(LC_ALL, "Russian");

	Auto* car[5];
	car[0] = new Bus;
	car[1] = new Big;
	for (int i = 0; i < 3; i++) car[i] = new Mini;
	for (int i = 0; i < 5; i++) car[i]->InPut();
	for (int i = 0; i < 5; i++) car[i]->OutPut();
	system("pause");
}