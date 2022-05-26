<Query Kind="Statements" />

using System;
/*
Instance Constructor: initialize code on a class or struct. (make an instance of a class/struct object)
	- can have the following modifiers
		access modifiers: public, internal, private, protected
		unmanaged code modifiers: unsafe, extern  
*/

var rect = new Rectangle(3,4);
Console.WriteLine(rect);
(var width, var height) = rect;	// deconstruction
Console.WriteLine($"{width}, {height}");

Panda pete = new Panda("Pete"); // calling instance constructor

public class Panda
{
	string name;
	int age = 2;
	public Panda(string n, int a)	// instance constructor
	{
	 	name = n;
		age = a;
	}
	
	public Panda(string n) => name = n; // expression-bodied instance constructor
}

public class Wine
{
	public decimal Price;
	public int Year;
	public Wine(decimal price) => Price = price;						
	public Wine(decimal price, int year) : this(price) => Year = year;		// constructor overloading
	public Wine(decimal price, DateTime year) : this(price, year.Year) {}	// passsing expression
}

public class Class1
{
	Class1(){} 						// non-public constructor
	
	public static Class1 Create()	// create new instance via a static method call
	{
		return new Class1();
	}
}

/*
Deconstructor (deconstructing method): opposite of a constructor, assings fields back to a set of variables
	- must be called Deconstruct and have one or more out paramaters
*/
class Rectangle
{
	public readonly float Width, Height;
	
	public Rectangle(float width, float height)
	{
		Width = width;
		Height = height;
	}
	
	public void Deconstruct(out float width, out float height)
	{
		width= Width;
		height = Height;
	}
}




















