#include <stdlib.h>
#include <iostream>

using namespace std;

class Frac
{
private:
	int top;
	int bot;
public:
	Frac(int &a, int &b)
	{
		top = a;
		bot = b;
		Simpl();
	}
	~Frac()
	{

	}
	void Show()
	{
		cout << top << "/" << bot;
	}
	Frac Mult(Frac B)
	{
		Frac f(top, bot);
		f.top *= B.top;
		f.bot *= B.bot;
		f.Simpl();
		return f;
	}
	Frac Det(Frac B)
	{
		Frac f(top, bot);
		f.top *= B.bot;
		f.bot *= B.top;
		f.Simpl();
		return f;
	}
	Frac Summ(Frac B)
	{
		Frac f(top, bot);
		f.top = top*B.bot + B.top*bot;
		f.bot *= B.bot;
		f.Simpl();
		return f;
	}
	Frac Diff(Frac B)
	{
		Frac f(top, bot);
		f.top = f.top*B.bot - B.top*f.bot;
		f.bot *= B.bot;
		f.Simpl();
		return f;
	}
	Frac Summ()
	{
		Frac f(top, bot);
		f = Summ(f);
		f.Simpl();
		return f;
	}
private:
	void Simpl()
	{
		if (top == bot)
		{
			top = 1;
			bot = 1;
		}
		int t_tmp = top < 0 ? -top : top;
		int b_tmp = bot < 0 ? -bot : bot;
		int x = (t_tmp > b_tmp ? b_tmp : t_tmp);
		for (int i = 2; i <= x; i++)
		{
			if ((top % i == 0) && (bot % i == 0))
			{
				top /= i;
				bot /= i;
				i = 2;
				t_tmp = top < 0 ? -top : top;
				b_tmp = bot < 0 ? -bot : bot;
				x = (t_tmp > b_tmp ? b_tmp : t_tmp);
			}
		}

	}
};

void main()
{
	int x, y;
	cout << "First fraction:\nNumerator: ";
	cin >> x;
	cin.clear();
	cout << "Denominator: ";
	cin >> y;
	cin.clear();
	Frac f1(x, y);
	cout << "Second fraction:\nNumerator: ";
	cin >> x;
	cin.clear();
	cout << "Denominator: ";
	cin >> y;
	cin.clear();
	Frac f2(x, y);
	Frac r(x, y);

	f1.Show();
	cout << " * ";
	f2.Show();
	cout << " = ";
	r = f1.Mult(f2);
	r.Show();
	cout << "\n";

	f1.Show();
	cout << " / ";
	f2.Show();
	cout << " = ";
	r = f1.Det(f2);
	r.Show();
	cout << "\n";

	f1.Show();
	cout << " - ";
	f2.Show();
	cout << " = ";
	r = f1.Diff(f2);
	r.Show();
	cout << "\n";

	f1.Show();
	cout << " + ";
	f2.Show();
	cout << " = ";
	r = f1.Summ(f2);
	r.Show();

	cout << "\n";
	system("pause");
}