<Query Kind="Statements" />

/*
 Reference Types: made up of two parts, reference and object.
 	- Reference points to where object is held in memory
	- String, Object, Class, Array, Delegate
	- assigning a reference type copies the refernece (not the object!)
	- reference tyoes can be assigned null 
		- this means the reference does not point to any object
*/

Point p1 = new Point();
p1.X=5;
Point p2 = p1;
Console.WriteLine($"{p1.X} {p2.X}");
p1.X=9;
Console.WriteLine($"{p1.X} {p2.X}");
Point p3 = null;


public class Point{public int X, Y;}