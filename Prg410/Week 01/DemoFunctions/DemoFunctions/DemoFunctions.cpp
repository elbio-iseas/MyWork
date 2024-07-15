// DemoFunctions.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
#include <conio.h>
#include <cstdlib>
#include <ctime>
#include <string>
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

void say (int x, int y, string message)
{
	gotoxy(x,y);
	cout<< message;
}

// this function when called it clear the console screen
// it uses the system OS command CLS
void clearscreen()
{
	system("CLS"); 
}

// this function makes the border of a box with five parameters :
// top left screen column coordinate
// top left screen line coordinate
// bottom right screen column coordinate
// bottom right screen line coordinate
// the parameter symbol can have one of three possible values
// 0 for blank
// 1 for single line
// 2 for double line
void drawboxborder(int x1, int y1, int x2, int y2, int symbol)
{
	 string topleftcorner, 
			toprightcorner, 
			bottomleftcorner, 
			bottomrightcorner, 
			topsymbol, 
			bottomsymbol, 
			leftsymbol, 
			rightsymbol;

	if (symbol == 0)
	{
		topleftcorner     = " ";
		toprightcorner    = " ";
		bottomleftcorner  = " ";
		bottomrightcorner = " ";
		topsymbol        = " ";
		bottomsymbol      = " ";
		leftsymbol       = " ";
		rightsymbol       = " ";
	}
	else if (symbol == 1 || symbol == 2)
	{
		if (symbol == 1)
		{	
			topleftcorner     = "⌐";
			toprightcorner    = "¬";
			bottomleftcorner  = "└";
			bottomrightcorner = "┘";
			topsymbol        = "─";
			bottomsymbol      = "─";
			leftsymbol       = "│";
			rightsymbol       = "│";
		}
		else
		{
			topleftcorner     = "╔";
			toprightcorner    = "╗";
			bottomleftcorner  = "╚";
			bottomrightcorner = "╝";
			topsymbol        = "═";
			bottomsymbol     = "═";
			leftsymbol       = "║";
			rightsymbol       = "║";
		}

	}  

	if (symbol >= 0 && symbol <= 2)
	{
		int col, line;
		gotoxy(x1,y1);
		cout<< topleftcorner;
		getch();
		gotoxy(x2,y1);
		cout<< toprightcorner;
		for (col = x1+1; col <= x2-1, col++;)
		{
			cout << topsymbol;
		}
		for (line = y1+1; line <= y2-1, line++;)
		{
			gotoxy(x1,line);
			cout << leftsymbol;
			gotoxy(x2,line);
			cout << rightsymbol;
		}
		gotoxy(x1,y2);
		cout<< bottomleftcorner;
		gotoxy(x2,y2);
		cout<< bottomrightcorner;
		for (col = x1+1; col <= x2-1, col++;)
		{
			cout << bottomsymbol;
		}
	}
}
    

void paintbox(int x1, int y1, int x2, int y2, string symbol)
{
	int col, line;
	for (line = y1; line <= y2; line++)
	{
		for (col = x1; col <= x2; col++)
		{
			say(col,line,symbol);
		}
	}

}

int _tmain(int argc, _TCHAR* argv[])
{
	HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	SMALL_RECT windowSize = { 0,0,160,160 };

	SetConsoleWindowInfo(hConsole, TRUE, &windowSize); 

	//UINT GetConsoleOutputCP();
	//UINT GetConsoleCP();
	//BOOL SetConsoleOutputCP(UINT codePageID);
	//BOOL SetConsoleCP(UINT codePageID);

	SetConsoleOutputCP(1250);
	SetConsoleCP(1250);

	cout<< "Wait for me ... ";
	getch();

	clearscreen();
	
	say(10,10,"Look at that! It works ... ");
	getch();

	clearscreen();

	paintbox(0,0,160,160,"o");
	
	//drawboxborder(1,1,80,24,1);
	getch();

	return 0;
}

