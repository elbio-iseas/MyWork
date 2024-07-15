﻿// Anothertry.cpp : Defines the entry point for the console application.
// Author : Elbio Iseas 2015
// ====================================================================
#include "stdafx.h"
#include <iostream>
#include <iomanip>
#include <conio.h>
#include <cstdlib>
#include <ctime>
#include <string>
#include <windows.h>

using namespace std;

// ============================================================================================================
// https://msdn.microsoft.com/en-us/library/windows/desktop/ms686025(v=vs.85).aspx 
// result of the online research for the old C language function for positioning the cursor
// The purspose of this function is to position the cursor on screen
// so there is no need to use endl or leading blanks 
// ============================================================================================================
void gotoxy(int x, int y) // function with the two int parameters x, and y for column, and row respectively
{
	HANDLE hStdOut = GetStdHandle(STD_OUTPUT_HANDLE);
	COORD coord; // it creates an object COORD named coord for the screen coordinates
	coord.X = x; // it assigns the value of the parameter x (column) to the object coord.X
	coord.Y = y; // it assigns the value of the parameter y (row) to the object coord.Y
	SetConsoleCursorPosition(hStdOut, coord); // it sets the cursor position with the values of the object coord
}

// ====================================================================================
// this function displays a message or character in the x, y coordinates of the console
// x is the column argument to display the message
// y is the line argument to display the message
// message is the argument you want to display at the coordinates x, y
// ====================================================================================
void say (int x, int y, string message)
{
	gotoxy(x,y);
	cout<< message;
}
// =====================================================
// this function when called it clear the console screen
// it uses the system OS command CLS
// =====================================================
void clearscreen()
{
	system("CLS"); 
}

// ===============================================================
// this function makes the border of a box with five parameters :
// top left screen column coordinate
// top left screen line coordinate
// bottom right screen column coordinate
// bottom right screen line coordinate
// the parameter symbol can have one of three possible values
// 0 for blank
// 1 for single line
// 2 for double line
// ===============================================================
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
		topleftcorner = ( symbol == 1 ) ? "Ú": "É";
		toprightcorner = ( symbol == 1 ) ? "¿": "»"; 
		bottomleftcorner = ( symbol == 1 ) ? "À": "È";
		bottomrightcorner = ( symbol == 1 ) ? "Ù": "¼"; 
		topsymbol = ( symbol == 1 ) ? "Ä" : "Í";
		bottomsymbol = ( symbol == 1 ) ? "Ä" : "Í";
		leftsymbol = ( symbol == 1 ) ? "³" : "º";
		rightsymbol = ( symbol == 1 ) ? "³" : "º";
	}  

	if (symbol >= 0 && symbol <= 2)
	{
		int col, line;

		say(x1,y1,topleftcorner);
		say(x2,y1,toprightcorner);

		for (col = x1+1; col <= x2-1; col++)
			say(col,y1,topsymbol);
		for (line = y1+1; line <= y2-1; line++)
		{		
			say(x1,line,leftsymbol);
			say(x2,line,rightsymbol);
		}

		say(x1,y2,bottomleftcorner);
		say(x2,y2,bottomrightcorner);

		for (col = x1+1; col <= x2-1; col++)
			say(col,y2,bottomsymbol);
	}
}

// ======================================================================
// This function draws a chart for the seats availability
// using two parameters: col (for column) and line ( for line) on
// screen. col and line represent the coordinates of the top-left corner
// ======================================================================
void drawtheater( int col, int line )
{
	say( col, line      , "┌──────┬───┬───┬───┬───┬───┬───┬───┬───┬───┬───┐"); 
	say( col, line + 1  , "│      │ 1 │ 2 │ 3 │ 4 │ 5 │ 6 │ 7 │ 8 │ 9 │1 0│");
	say( col, line + 2  , "├──────┼───┼───┼───┼───┼───┼───┼───┼───┼───┼───┤"); 
	say( col, line + 3  , "│ROW  1│   │   │   │   │   │   │   │   │   │   │");
	say( col, line + 4  , "├──────┼───┼───┼───┼───┼───┼───┼───┼───┼───┼───┤"); 
	say( col, line + 5  , "│ROW  2│   │   │   │   │   │   │   │   │   │   │");
	say( col, line + 6  , "├──────┼───┼───┼───┼───┼───┼───┼───┼───┼───┼───┤"); 
	say( col, line + 7  , "│ROW  3│   │   │   │   │   │   │   │   │   │   │");
	say( col, line + 8  , "├──────┼───┼───┼───┼───┼───┼───┼───┼───┼───┼───┤"); 
	say( col, line + 9  , "│ROW  4│   │   │   │   │   │   │   │   │   │   │");
	say( col, line + 10 , "├──────┼───┼───┼───┼───┼───┼───┼───┼───┼───┼───┤"); 
	say( col, line + 11 , "│ROW  5│   │   │   │   │   │   │   │   │   │   │");
	say( col, line + 12 , "├──────┼───┼───┼───┼───┼───┼───┼───┼───┼───┼───┤"); 
	say( col, line + 13 , "│ROW  6│   │   │   │   │   │   │   │   │   │   │");
	say( col, line + 15 , "├──────┼───┼───┼───┼───┼───┼───┼───┼───┼───┼───┤"); 
	say( col, line + 16 , "│ROW  7│   │   │   │   │   │   │   │   │   │   │");
	say( col, line + 17 , "├──────┼───┼───┼───┼───┼───┼───┼───┼───┼───┼───┤"); 
	say( col, line + 18 , "│ROW  8│   │   │   │   │   │   │   │   │   │   │");
	say( col, line + 19 , "├──────┼───┼───┼───┼───┼───┼───┼───┼───┼───┼───┤"); 
	say( col, line + 20 , "│ROW  9│   │   │   │   │   │   │   │   │   │   │");
	say( col, line + 21 , "├──────┼───┼───┼───┼───┼───┼───┼───┼───┼───┼───┤"); 
	say( col, line + 20 , "│ROW 10│   │   │   │   │   │   │   │   │   │   │");
	say( col, line + 21 , "└──────┴───┴───┴───┴───┴───┴───┴───┴───┴───┴───┘"); 

}

// =======================================================================
// this function paints a screen box with the symbol passed as an argument
// x1 is the left column value of the top left corner
// y1 is the top line value for the top left corner
// x2 is the right column value of the bottom right corner
// y2 is the bottom line value of the bottom right corner
// symbol is the character you pass as argument to fill the box
// =======================================================================
void paintbox(int x1, int y1, int x2, int y2, string symbol)
{
	int col, line;
	for (line = y1; line <= y2; line++)
	{
		for (col = x1; col <= x2; col++)
			say(col,line,symbol);
	}

}

int _tmain(int argc, _TCHAR* argv[])
{
	HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	SMALL_RECT windowSize = { 0,0,80,24 };

	SetConsoleWindowInfo(hConsole, TRUE, &windowSize); 

	clearscreen();

	paintbox(0,0,79,24,"°");
	say(3, 6,"│");
	drawtheater( 5, 1);
		
	getch();

	return 0;
}

