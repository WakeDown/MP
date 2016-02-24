//#include "stdafx.h"
#include <iostream>
#include <locale.h>
using namespace std;

void main()
{
	setlocale(LC_ALL, "rus");
	int stolbs = 0;
	int** smej = new int*[8];
	for (int o = 0; o < 8; o++)
		smej[o] = new int[8];

	for (int i = 0; i < 8; i++)
	{
		for (int j = 0; j < 8; j++)
			smej[i][j] = 0;
	}
	int i, j;
	for (int a = 0; a < 11; a++)
	{
		cout << "¬ведите св€занные вершины графа (число(пробел)число):" << endl;
		cin >> i >> j;
		smej[i - 1][j - 1] = 1;
		smej[j - 1][i - 1] = 1;
		stolbs ++;
	}
	for (int a = 0; a < 8; a++)
	{
		for (int b = 0; b < 8; b++)
			cout << smej[a][b] << " ";
		cout << endl;
	}
	puti(smej, 0, 0);
	
	
	
	system("pause");
}