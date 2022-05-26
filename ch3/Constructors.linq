<Query Kind="Statements" />

using System;
/*
Instance Constructor: initialize code on a class or struct. (make an instance of a class/struct object)
	- can have the following modifiers
		access modifiers: public, internal, privte, protected
		unmanaged code modifiers: unsafe, extern  
*/

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