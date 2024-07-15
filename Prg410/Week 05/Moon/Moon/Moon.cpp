//
// Moon.cpp : Defines the entry point for the console application.
// 
// The errors I found before compilation were the following:
// The semicolon after the class name Moon is syntactically wrong.
// The key word private was capitalized and it has to be lowercase.
// The semicolon afte Private must be a colon.
// The same thing with Public, lowercase and with a colon after.
// The method moonWeight(double ew) needs to be void not double.
// The name also needs to be void moonWeigh(double ew).
// The statement cout >> has the angle brackets pointing the wrong
// way, they has to be <<.
// The statement cin << has the angle brackets pointing the wrong
// way, they has to be >>.
// The semicolon at the end of the class block definition was
// missing.
// I had to split the Moon class instance lunar and pass the
// argument in another line: lunar.moonWeigh(earth) to make it 
// work.
// I had to add a header #include <conio.h> to use a function
// getch() to stop the screen to be able to see the results.
// There was a line with no good practice programming:
// two statements one afte the other on the same line that 
// I fixed by splitting in two lines.

#include "stdafx.h"
#include <iostream>
#include <conio.h>

using namespace std;

class Moon
{
private:
	double earthWeight;
	double moonWeight;
public:
    void moonWeigh(double ew)
	{
		earthWeight = ew;
		moonWeight = earthWeight / 6;
	}
	double getMoonWeight()
	{
		return moonWeight;
	}
};

int _tmain(int argc, _TCHAR* argv[])
{
	double earth;
	cout << "What is your weight? ";
	cin >> earth;
	Moon lunar;
	lunar.moonWeigh(earth);
	cout << "On the moon you would weigh "
		 << lunar.getMoonWeight() << endl;
	getch();

	return 0;
}

