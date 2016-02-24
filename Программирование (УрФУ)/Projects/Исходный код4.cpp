#include <iostream>
#include <string>
using namespace std;

int main()
{
	setlocale(LC_CTYPE, "Russian");
	double sum, stav, s=0, o=0;
	int years;
	cout << "Ваша сумма равна: ";
	cin >> sum;
	cout << endl << "Размер ставки: ";
	cin >> stav;
	cout <<endl;
	for ( years = 1; years <11; years ++)
	{
		sum += sum * stav;
		s = (sum * stav);
		o += s;
		cout << "Прибыль за " << years << " год(а)(лет) = " << s << endl;
	}
	cout << "Общая прибыль составляет: " << o << endl;
	system ("pause");
	return 0;
}