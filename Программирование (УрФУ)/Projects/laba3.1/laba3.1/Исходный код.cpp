#include <stdio.h>
#include <iostream>
using namespace std;

class Drobi
{
private:
	int a, b;
	char f;
public:
 Drobi()
	{}
void vvod()
  {
	  Drobi ch;
	  cin >> ch.a >> f >> ch.b;
  }

void summ(Drobi ch1, Drobi ch2)
{
	Drobi otvet;
	otvet.a=ch1.a*ch2.b+ch2.a*ch1.b;
	otvet.b=ch1.b*ch2.b;
}
void razn(Drobi ch1, Drobi ch2)
{
	Drobi otvet;
	otvet.a=ch1.a*ch2.b-ch2.a*ch1.b;
	otvet.b=ch1.b*ch2.b;
}
void umn(Drobi ch1, Drobi ch2)
{
	Drobi otvet;
	otvet.a=ch1.a*ch2.a;
	otvet.b=ch1.b*ch2.b;
}
void del(Drobi ch1, Drobi ch2)
{
	Drobi otvet;
	otvet.a=ch1.a*ch2.b;
	otvet.b=ch1.b*ch2.a;
}
Drobi upr(Drobi otvet)
{
	Drobi vivod;
	vivod.a=otvet.a;
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
void vivod(Drobi vivod)
{
cout << " = "<< vivod.a << "/" << vivod.b << endl;
}
};


int main()
{
	setlocale(LC_CTYPE, "Russian");
	char znak;
	Drobi ch1;
	ch1.vvod();
	cin >> znak;
	Drobi ch2;
	ch2.vvod();
	if (znak == '+')
	{
	 ch1.summ(ch1, ch2);	
	 Drobi vivod = ch1.upr(ch1);
	 vivod.vivod(vivod);
	}
	if (znak == '-')
	{
	 ch1.razn(ch1, ch2);
	Drobi vivod = ch1.upr(ch1);
	vivod.vivod(vivod);
	}
	if (znak == '*')
	{
	ch1.umn(ch1, ch2);
	Drobi vivod = ch1.upr(ch1);
	vivod.vivod(vivod);
	}
	if (znak == '/')
	{
	 ch1.del(ch1, ch2);
	 Drobi vivod = ch1.upr(ch1);
	 vivod.vivod(vivod);
	}
	system ("pause");
	return 0;
}