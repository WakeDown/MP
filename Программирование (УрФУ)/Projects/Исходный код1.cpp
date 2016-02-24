#include <iostream>
#include <string>
using namespace std;

struct Time
{
	int HH, MM, SS, sec;
};

int tts(Time clock);
Time sum(Time clock1, Time clock2);
Time supstr(Time clock1, Time clock2);
Time stt(Time clock3);

int main()
{
	setlocale(LC_CTYPE, "Russian");
	Time clock1;
	Time clock2;
	Time clock3;
	clock3.HH=clock3.MM=clock3.SS=0;
	char c, znak;
	cin >> clock1.HH >> c >> clock1.MM >> c >> clock1.SS;
	cin >> znak;
	cin >> clock2.HH >> c >> clock2.MM >> c >> clock2.SS;
	clock1.sec = 0;
	clock2.sec = 0;
	clock3.sec=0;
	if (znak == '+')
	{
	 Time clock = sum(clock1, clock2);
	 cout << "Ответ:  " << clock.HH << ":" << clock.MM << ":" << clock.SS << endl;
	}
	if (znak == '-')
	{
	 Time clock = supstr(clock1, clock2);
	 cout << "Ответ:  " << clock.HH << ":" << clock.MM << ":" << clock.SS << endl;
	}
	system ("pause");
	return 0;
}

int tts(Time clock)
{
	clock.sec = clock.HH * 3600 + clock.MM * 60 + clock.SS;
	
	return clock.sec;
}


Time sum(Time clock1, Time clock2)
{
	Time clock;
	clock.HH=clock.MM=clock.SS=0;
	clock1.sec = tts(clock1);
	clock2.sec = tts(clock2);
	clock.sec = clock1.sec + clock2.sec;
	Time clock = stt(clock);
	return clock;
	//stt(clock3);
}
Time supstr(Time clock1, Time clock2)
{
	Time clock;
	clock.HH=clock.MM=clock.SS=0;
	clock1.sec = tts(clock1);
	clock2.sec = tts(clock2);
	clock.sec = clock1.sec - clock2.sec;
	Time clock = stt(clock);
	return clock;
	//stt(clock3);
}

Time stt(Time clock3)
{
	clock3.HH = clock3.sec / 3600;
	clock3.MM = clock3.sec / 60 - clock3.HH * 60;
	clock3.SS = clock3.sec - clock3.HH * 3600 - clock3.MM * 60;
	return clock3;
	
}