#include <iostream>
#include <string>
using namespace std;

int main()
{
	setlocale(LC_CTYPE, "Russian");
	string str;
	cin >> str;
	if(str.at(0) >= '0' && str.at(0) <= '9') cout << endl << "Это не индетификатор" << endl;
	else cout << "Это индетификатор " << endl;
	
	/*for (int i = 1; size_t(i) < str.size(); ++i)
	{
                for (int j = 0; size_t(j) < str.size()-i; ++j)
		{
            if (str[j] > str[j + 1])
			{
                char temp = str[j];
                str[j] = str[j + 1];
                str[j + 1] = temp;
            }
        
        }
	}
	if (str[str.size()-1]== '1' ||
		str[str.size()-1]== '2' ||
		str[str.size()-1]== '3' ||
		str[str.size()-1]== '4' ||
		str[str.size()-1]== '5' ||
		str[str.size()-1]== '6' ||
		str[str.size()-1]== '7' ||
		str[str.size()-1]== '8' ||
		str[str.size()-1]== '9' ||
		str[str.size()-1]== '0')
	{cout << "Перед нами число" << endl;}
	else {cout << "Перед нами индетификатор" <<endl;}
	//cout << str << endl;
	//cout << str[str.size()-1] << endl;*/
	system ("pause");
	return 0;
}