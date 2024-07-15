// FavoriteColor.cpp : Defines the entry point for the console application.
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


void displaymenu()
{
	say(35, 7, "1.- Black");
	say(35, 8, "2.- White");
	say(35, 9, "3.- Red");
	say(35,10, "4.- Blue");
	say(35,11, "5.- Green");
	say(35,12, "6.- Yellow");
	say(35,13, "7.- Orange");
	say(35,14, "8.- Violet");
	say(35,15, "9.- Turquoise");
	say(27,17, "What's your favorite color?");
	say(26,18, "Press the key of your choice.");
	gotoxy(56,18);
}
void selectanddisplay()
{
	int option = 0;
	char keystroke = '0';
	string color = "";
	string colormessage = "";
	bool keepgoing = true;

	do
	{
		say(14,22,"                                                    ");
		gotoxy(56,18);
		keystroke=getch();
		
		if (isdigit(keystroke))
		{
			option = static_cast<int>(keystroke);
						
			if (keystroke!='0')
			   keepgoing = false;
		}
		else
		{
		   say(14,22,"Try again with 1 - 9. Press any key to continue ... ");
		   gotoxy(56,18);
		   getch();
		}
	}
	while (keepgoing);

	if (option == 49)
	{
		color = "Black.";
	}
	else if (option == 50)
	{
		color = "White.";
	}
	else if (option == 51)
	{
		color = "Red.";
	}
	else if (option == 52)
	{
		color = "Blue.";
	}
	else if (option == 53)
	{
		color = "Green.";
	}
	else if (option == 54)
	{
		color = "Yellow.";
	}
	else if (option == 55)
	{
		color = "Orange.";
	}
	else if (option == 56)
	{
		color = "Violet.";
	}
	else if (option == 57)
	{
	   color = "Turquoise.";
	}
	colormessage ="Your favorite color is : " + color + " ";
	say(10,22,"                                                    ");
	say(23,22,colormessage);
	getch(); 
}
int _tmain(int argc, _TCHAR* argv[])
{
	HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	SMALL_RECT windowSize = { 0,0,80,24 };

	SetConsoleWindowInfo(hConsole, TRUE, &windowSize); 

	clearscreen();
	drawboxborder(24,1,55,3,1);
	say(26, 2, "F A V O R I T E    C O L O R");
	drawboxborder(20,5,59,19,1);
    displaymenu();
	drawboxborder(0,21,79,23,1);
	selectanddisplay();	

	return 0;
}

/*
    switch (option)
	{
		case 49 :
		{
			color = "Black.";
			break;
		}
		case 50 :
		{ 
			color = "White.";
			break;
		}
		case 51)
		{
			color = "Red.";
			break;
		}
		case 52 :
		{
			color = "Blue.";
			break;
		}
		case 53 :
		{
			color = "Green.";
			break;
		}
		case 54 :
		{
			color = "Yellow.";
			break;
		}
		case 55 :
		{
			color = "Orange.";
			break;
		}
		case 56 :
		{
			color = "Violet.";
			break;
		}
		case 57 : 
		{
		   color = "Turquoise.";
		   break;
		}
	}
*/
// This block could replace the nested if block.
// Notice that there is no default reserved word in the switch statement. 
// This is because there is no room for another value for option
// since it came from a control block that only allowed 49 to 57 values.

