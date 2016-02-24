#include<stdio.h>
#include <iostream>
#include <vector>
#include <stdlib.h>
using namespace std;

int n=0;
typedef struct tree
  {
    int b;              // данные
    struct tree *left;  // левый  сын
    struct tree *right; // правый сын
  } TREE;

TREE *add_to_tree(TREE *root, int new_value)
{
   if (root==NULL)  // если нет сыновей - создаем новый элемент
     {
        root = (TREE*)malloc(sizeof(TREE));
        root->b = new_value;
        root->left = root->right = 0;
        return root;
     }
   if (root->b < new_value)          // добавлем ветвь
     {root->right = add_to_tree(root->right, new_value);
   }
   else
     root->left  = add_to_tree(root->left,  new_value);
   return root;
}

void tree_to_array(TREE *root, int b[]) // процедура заполнения массива
  {
    static int max2=0;                      // счетчик элементов нового массива
    if (root==NULL) return;             // условие окончания - нет сыновей
	tree_to_array(root->left, b);       // обход левого поддерева
    b[max2++] = root->b;
	tree_to_array(root->right, b);      // обход правого поддерева
    free(root);
  }

void SortTree(int b[], int elem_total)        // собственно сортировка
{
   TREE *root;
   int i;
   int schet=0;
   root = NULL;
   for (i=0; i<elem_total; i++)        // проход массива и заполнение дерева
   {
      root = add_to_tree(root, b[i]);
	  schet ++;
   }
   tree_to_array(root, b);            // заполнение массива
   cout << "Сортировка деревом: " << endl;
	for (int i=0;i<15;i++)
	{cout << b[i] << " ";}
	cout << endl << "Количество действий: " << schet;
	cout << endl << endl;
	schet=0;
}

void SheikerSort(int *b, const int n)
{
	int schet=0;
           int l, r, i, k, buf;
           k = l = 0;
           r = n - 2;
           while(l <= r)
           {
              for(i = l; i <= r; i++)
                 if (b[i] > b[i+1])
                 {
                    buf = b[i]; b[i] = b[i+1]; b[i+1] = buf;
                    k = i;
                 }
              r = k - 1;
              for(i = r; i >= l; i--)
				  if (b[i] > b[i+1])
                 {
                    buf = b[i]; b[i] = b[i+1]; b[i+1] = buf;
                    k = i;
                 }
              l = k + 1;
			  schet ++;
           }
		   	cout << "Шейкерная сортировка: " << endl;
	for(int i = 0; i < 15; i++)
	{ cout << b[i] << " ";}
	cout << endl << "Количество действий: " << schet;
	cout << endl << endl;
	schet=0;
}
 
int main()
{
	setlocale(LC_CTYPE, "Russian");
	int a[15] = {2, 5, 7, 22, 3, 15, 30, 5, 96, 28, 4, 10, 1, 12, 58 };
	int b[15] = {1, 2, 3, 4, 5, 6, 7, 8, 8, 10, 11, 12, 13, 14, 15 };
	int c[15] = {15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

	SheikerSort(a, 15);
	SheikerSort(b, 15);
	SheikerSort(c, 15);

	cout << "*******************************************************" << endl;

	SortTree(a, 15);
	SortTree(b, 15);
	SortTree(c, 15);
	
	system ("pause");
	return 0;
}