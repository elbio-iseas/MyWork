// Iteration.cpp : Defines the entry point for the console application.
// Author : Elbio Iseas

#include "stdafx.h"
#include <conio.h>
#include <iostream>
#include <string>
#include <array>

using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	string student[4];

	student[0] = "Paul";
	student[1] = "Jennifer";
	student[2] = "Tom";
	student[3] = "Ashley";

	int index = 0;

	cout << "Students listed with a while loop." << endl << endl;

	while ( index <= 3)
	{
		cout << student[index] << endl;
		index++;
    }

	cout << endl;
	cout << endl;

	cout << "Students listed with a for loop." << endl << endl;

	for ( index = 0; index <= 3; index++ )
		cout << student[index] << endl;

	cout << endl;
	cout << endl;
	cout << "Press any key to exit ... ";
	getch();

	return 0;
}
