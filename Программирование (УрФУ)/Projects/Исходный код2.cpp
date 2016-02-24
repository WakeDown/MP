#include <iostream>
#include <iomanip>
using namespace std;
 
int main()
{
    const int size = 10;
    int i = 0;
 
    for(i = 0; i < size*size; i++)
    {
        cout << setw(4) << (i/size + 1)*(i%size + 1);
 
        if((i + 1)%size == 0) cout << endl;
    }
	system ("pause");
return 0;
}