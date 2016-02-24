#include <iostream>
#include <stdlib.h>
#include <string>

using namespace std;

enum Napr
{
	ZERO = 0,
	UP = 1,
	DOWN = 2
};

struct Coor
{
	int Grad;
	int Min;
	Napr N;
};

struct Location
{
	Coor X;//Долг
	Coor Y;//Шир
};

class Ship
{
private:
	string Name;
	Location Loc;
public:
	Ship()
	{}
	Ship(string na, Location l)
	{
		Input(na, l);
	}

	void Input(string str, Location &l)
	{
		Name = str;
		Loc = l;
	}

	void Output()
	{
		cout << Name << "\n" << Loc.X.Grad << "* " << Loc.X.Min << "' : " << Loc.Y.Grad << "* " << Loc.Y.Min << "'\n";
		if (Loc.X.N == 0)
		{
			switch (Loc.Y.N)
			{
			case 0: cout << "Is stay."; break;
			case 1: cout << "Is going to N."; break;
			case 2: cout << "Is going to S."; break;
			default:
				break;
			}
		}
		if (Loc.X.N == 1)
		{
			switch (Loc.Y.N)
			{
			case 0: cout << "Is going to E"; break;
			case 1: cout << "Is going to NE."; break;
			case 2: cout << "Is going to SE."; break;
			default:
				break;
			}
		}
		if (Loc.X.N == 2)
		{
			switch (Loc.Y.N)
			{
			case 0: cout << "Is going to W"; break;
			case 1: cout << "Is going to NW."; break;
			case 2: cout << "Is going to SW."; break;
			default:
				break;
			}
		}
	}
};

void main()
{
	string Name;
	Location Loc;
	Ship *s;
	int n;
	cout << "Enter amount of ships: ";
	cin >> n;
	s = new Ship[n];
	if (!n) return;
	int q = 0;
	for (int i = 0; i < n; i++)
	{
		cout << i+1 << ". " << "NAME (without gaps): ";
		cin.clear();
		cin >> Name;
		cin.clear();
		cout << "LOCATION:\n\nLongitude:\ndegrees: ";
		cin >> Loc.X.Grad;
		cout << "minutes: ";
		cin >> Loc.X.Min;
		cout << "the relative direction (1 - the same direction ,2 - oppositel, 0 - perpendicular ): ";
		cin >> q;
		switch (q)
		{
		case 0: Loc.X.N = ZERO; break;
		case 1: Loc.X.N = UP; break;
		case 2: Loc.X.N = DOWN; break;
		default:{ cout << "Error!"; system("pause"); return; }
			break;
		}
		cin.clear();
		cout << "\nBreadth:\ndegrees: ";
		cin >> Loc.Y.Grad;
		cout << "minutes: ";
		cin >> Loc.Y.Min;
		cout << "the relative direction (1 - the same direction ,2 - oppositel, 0 - perpendicular ): ";
		cin >> q;
		switch (q)
		{
		case 0: Loc.Y.N = ZERO; break;
		case 1: Loc.Y.N = UP; break;
		case 2: Loc.Y.N = DOWN; break;
		default:{ cout << "Error!"; system("pause"); return; }
			break;
		}
		s[i].Input(Name, Loc);
		cout << "\n";
	}
	for (int i = 0; i < n; i++)
	{
		cout << "\n\n";
		s[i].Output();
	}
	cout << "\n\n";
	system("pause");
}