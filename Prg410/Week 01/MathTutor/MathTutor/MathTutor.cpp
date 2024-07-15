// MathTutor.cpp : Defines the entry point for the console application.
// Author: Elbio Iseas
// PRG/410 - Week One Individual Assignment 

#include "stdafx.h"
#include <iostream>
#include <iomanip>
#include <conio.h>
#include <cstdlib>
#include <ctime>
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
	int first  = 0, // first random number
		second = 0, // second random number
		result = 0; // result (sum of first + second numbers)

	unsigned int seed; // used in association with srand() and rand() to randomize numbers
	
	char finish = 'N'; // variable for finishing the tutor initialized in 'N' to force the entry to the while loop
	char answer = 'Y'; // variable for continueing or not with exercises

	gotoxy(70,6); // locates the cursor at these screen coordinates
	cout << "M A T H    T U T O R"; // it displays the title of the program on screen

	while (finish != 'Y')  // it will stay in the loop until the user wants to finish taking challenges
	{ 
		answer = 'N';
		
		seed = time(0);               // needed to generate random numbers
		srand(seed);                  // needed to generate random numbers
		first = rand() % 899 + 100;   // generates a random number in the range 100 to 999
		second = rand() % 899 + 100;  // generates a random number in the range 100 to 999

		gotoxy(78,10); // locates the cursor at these screen coordinates
		cout << "   "; // erases the screen number from last exercise if one
		gotoxy(78,10); // locates the cursor at these screen coordinates
		cout << setw(3) << first;

		gotoxy(76,12);  // locates the cursor at these screen coordinates
		cout << "     ";
		gotoxy(76,12);  // locates the cursor at these screen coordinates
		cout << "+ " << setw(3) << second;

		gotoxy(77,13); // locates the cursor at these screen coordinates
		cout << "    ";
		gotoxy(77,13); // locates the cursor at these screen coordinates
		cout << "----";

	    gotoxy(65,18); // locates the cursor at these screen coordinates
		cout << "                                 ";
		gotoxy(65,18); // locates the cursor at these screen coordinates
		cout << "Press any key to see the result. ";
		getch(); // it gets a character from screen and it is used to pause the program execution
		
		result = first + second; // it adds the two random numbers and it assigns the result to the variable result

		gotoxy(65,18); // locates the cursor at these screen coordinates
		cout << "                                 ";

		gotoxy(77,14); // locates the cursor at these screen coordinates
		cout << "    ";
		gotoxy(77,14); // locates the cursor at these screen coordinates
		cout << right << setw(4) << result;


		gotoxy(64,18); // locates the cursor at these screen coordinates
		cout << "                                      ";
		gotoxy(64,18); // locates the cursor at these screen coordinates
		cout << "Would you like another exercise?(Y/N) ";
		
		answer=' '; // this value it is on purpose to force the entry to the while loop
		while (answer!='Y' && answer!='N')  // it will stay in the while loop while the variable answer is different from 'Y' and different from 'N'
		{
			answer=getch(); // it gets a character from the keyboard and it assigns it to the variable answer
			answer=toupper(answer); // it changes to uppercase whatever the character read from the keyboard was
		}
		gotoxy(64,18); // locates the cursor at these screen coordinates
		cout << "                                      "; // it earases the old message
		gotoxy(77,14); // locates the cursor at these screen coordinates
		cout << "    "; // it erases the result value
		if (answer == 'N') // if the value of the variable answer is 'N' then it enters the if block
		{
			finish = 'Y'; // it assigns 'Y' to the flag variable finish to exit the program
		}
	}    
	return 0; // it returns 0 because it is an int function
}