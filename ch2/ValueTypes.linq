<Query Kind="Statements" />

using System;
/* Value Type: build in types stored directly in memory
	- all numeric types (int, short, long, double, ... )
	- char
	- bool
	- you can define custom value types by making a struct

*/
int x = 12;
char symbol = '@';
bool b = true;

// assignment of value types always copies the instance
Point p1 = new Point();
p1.X = 4;
Point p2 = p1;
Console.WriteLine($"{p1.X} {p2.X}");
p1.X = 5;
Console.WriteLine($"{p1.X} {p2.X}");

public struct Point {public int X, Y;}


