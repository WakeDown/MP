#include <iostream>
#include <string>
using namespace std;

struct vvod
{
	int a, b;
};
vvod summ(vvod chislo1, vvod chislo2);
vvod razn(vvod chislo1, vvod chislo2);
vvod umn(vvod chislo1, vvod chislo2);
vvod del(vvod chislo1, vvod chislo2);
vvod sokr(vvod otvet);

int main()
{
	setlocale(LC_CTYPE, "Russian");
	char znak, f;
	vvod chislo1;
	vvod chislo2;
	cin >> chislo1.a >> f >> chislo1.b >> znak >> chislo2.a >> f >> chislo2.b;
	if (znak == '+')
	{
	 vvod otvet = summ(chislo1, chislo2);
	 vvod vivod = sokr(otvet);
	 cout << " = " << vivod.a << "/" << vivod.b << endl;
	}
	if (znak == '-')
	{
	vvod otvet =  razn( chislo1,  chislo2);
	vvod vivod = sokr(otvet);
	cout << " = " << vivod.a << "/" << vivod.b << endl;	}
	if (znak == '*')
	{
	vvod otvet =  umn( chislo1,  chislo2);
	vvod vivod = sokr(otvet);
	cout << " = " << vivod.a << "/" << vivod.b << endl;	}
	if (znak == '/')
	{
	vvod otvet =  del( chislo1,  chislo2);
	vvod vivod = sokr(otvet);
	cout << " = " << vivod.a << "/" << vivod.b << endl;	}
	system ("pause");
	return 0;
}

vvod summ(vvod chislo1, vvod chislo2)
{
	vvod otvet;
	otvet.b = chislo2.b * chislo1.b;
	otvet.a = chislo1.a*chislo2.b + chislo1.b*chislo2.a;
	return otvet;	
}

vvod razn(vvod chislo1, vvod chislo2)
{
	vvod otvet;
	otvet.b = chislo2.b * chislo1.b;
	otvet.a = chislo1.a*chislo2.b - chislo1.b*chislo2.a;
	return otvet;

}

vvod umn(vvod chislo1, vvod chislo2)
{
	vvod otvet;
	otvet.b = chislo1.b * chislo2.b;
	otvet.a = chislo1.a * chislo2.a;
	return otvet;
}

vvod del(vvod chislo1, vvod chislo2)
{
	vvod otvet;
	otvet.b = chislo1.b * chislo2.a;
	otvet.a = chislo1.a * chislo2.b;
	return otvet;
}

vvod sokr(vvod otvet)
{ vvod vivod;
	vivod.a =otvet.a;
	vivod.b=otvet.b;
 
for(int i=1; i<=otvet.a && i<=otvet.b; i++)
  {
	  int aa=otvet.a%i;
  int bb=otvet.b%i;
  if(!(otvet.a%i) && !(otvet.b%i))
    {
    vivod.a=otvet.a/i;
	vivod.b=otvet.b/i;
    }
  }
return vivod;
}
