#include <iostream>
#include <fstream>
#include <string>
#include <stdio.h>
using namespace std;

void kodRLE();
void dekodRLE();

void main()
{
	setlocale(LC_ALL, "rus");
	ifstream file1;
	file1.open("C:\\Users\\trefi\\Desktop\\file1.txt");
	string text;
	getline(file1, text);
	cout << "Кодируем" << endl;
	cout << text << endl;
	file1.close();
	kodRLE();
	ifstream file2;
	file2.open("C:\\Users\\trefi\\Desktop\\file2.txt");
	string code;
	getline(file2, code);
	cout << code << endl;
	cout << "Декодируем" << endl;
	dekodRLE();
	getline(file2, code);
	cout << code << endl;
	getline(file1, text);
	cout << text << endl;
	file2.close();
	system("pause");
}

void kodRLE()
{
	ifstream file1;
	file1.open("C:\\Users\\trefi\\Desktop\\file1.txt");
	ofstream file2;
	file2.open("C:\\Users\\trefi\\Desktop\\file2.txt");
	char simv;
	int num = 1;
	while(file1.good())
    {
        file1.get(simv);
        if(simv != file1.peek()|| num==9)
        {
            file2<<num<<simv;
            num=0;
        }
		num++;
    }
	file1.close();
	file2.close();
}

void dekodRLE()
{
	ofstream file1;
	file1.open("C:\\Users\\trefi\\Desktop\\file1.txt");
	ifstream file2;
	file2.open("C:\\Users\\trefi\\Desktop\\file2.txt");
	char simvDO, simvPOSLE;

	const char num = '0';
    while(file2.peek()!=EOF)
    {
		file2.get(simvDO);
		file2.get(simvPOSLE);
		for(int i=0; i < simvDO - num; i++)
			file1 << simvPOSLE;
    }
 
    file1.close();
    file2.close();
}