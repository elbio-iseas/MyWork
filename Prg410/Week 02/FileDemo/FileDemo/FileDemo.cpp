// FileDemo.cpp : Defines the entry point for the console application.
// Author : Elbio Iseas

#include "stdafx.h"
#include <conio.h>
#include <iostream>
#include <fstream>
#include <string>
#include <array>


using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	string dept[4];

	ofstream outfile;
	outfile.open("filedemo.txt");

	outfile << "Accounting\n";
	outfile << "Human Resources\n";
	outfile << "Personnel\n";
	outfile << "Recruiting\n";

	outfile.close();

	ifstream infile;
	infile.open("filedemo.txt");

	infile >> dept[0];
	infile >> dept[1];
	infile >> dept[2];
	infile >> dept[3];

	infile.close();

	cout << endl;
	cout << endl;


	for (int i = 0; i < 4; i++)
		cout << dept[i] << endl;

	cout << endl;
	cout << endl;
	cout << "Press any key to exit ... ";
	getch();

	return 0;
}

