// SizeofDemo.cpp : Defines the entry point for the console application
// Author: Elbio Iseas
// PRG/410 - Week One Supporting Activity Data Types in C++ 

#include "stdafx.h"
#include <iostream>
#include <conio.h>
#include <Windows.h>

using namespace std;

// https://msdn.microsoft.com/en-us/library/windows/desktop/ms686025(v=vs.85).aspx 
// result of the online research for the old C language function for positioning the cursor
// The purspose of this function is to position the cursor on screen
// so there is no need to use endl or leading blanks 
void gotoxy(int x, int y) // function with the two int parameters x, and y for column, and row respectively
{
	HANDLE hStdOut = GetStdHandle(STD_OUTPUT_HANDLE);
	COORD coord; // it creates an object COORD named coord for the screen coordinates
	coord.X = x; // it assigns the value of the parameter x (column) to the object coord.X
	coord.Y = y; // it assigns the value of the parameter y (row) to the object coord.Y
	SetConsoleCursorPosition(hStdOut, coord); // it sets the cursor position with the values of the object coord
}
int _tmain(int argc, _TCHAR* argv[])
{

	int num = 2015;
	double credcardBalance = 5345.81;
	char keyPressed = 'E';
	short age = 21;

	gotoxy(10,10);
	cout << "The size in memory of the int variable num is " << sizeof(num) << " bytes.";
	gotoxy(10,11);
	cout << "The size in memory of the double variable credcardBalance is " << sizeof(credcardBalance) << " bytes.";
	gotoxy(10,12);
	cout << "The size in memory of the char variable keyPressed is " << sizeof(keyPressed) << " byte.";
	gotoxy(10,13);
	cout << "The size in memory of the short variable age is " << sizeof(age) << " bytes.";
	gotoxy(10,15);
	cout << "Press any key to finish the program ... ";
	getch();

	return 0;
}

