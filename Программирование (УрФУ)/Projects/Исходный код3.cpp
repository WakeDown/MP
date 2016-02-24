#include <iostream>
#include <string>
using namespace std;

long double fact(int n);

int main()
{
	int n, m;
	setlocale(LC_CTYPE, "Russian");
	cout << "ƒано n количество людей и m колчество стульев." << endl << "Ќеобходимо расчитать количество вариантов рассаживани€ людей на стуль€" << endl;
	cout << "¬ведите число людей:" << endl << "n=";
	cin >> n;
	cout  << endl << "¬ведите число стульев:" << endl << "m=";
	cin >> m;
	int s= fact(m) / fact(n) / fact(m-n) ;
	cout << endl << "ќтвет на поставленную задачу: " << s << " вариантов" << endl;
	system ("pause");
	return 0;
};

long double fact(int N)
{
    if(N < 0) // если пользователь ввел отрицательное число
        return 0; // возвращаем ноль
    if (N == 0) // если пользователь ввел ноль,
        return 1; // возвращаем факториал от нул€ - не удивл€етесь, но это 1
    else // ¬о всех остальных случа€х
        return N * fact(N - 1); // делаем рекурсию.
}