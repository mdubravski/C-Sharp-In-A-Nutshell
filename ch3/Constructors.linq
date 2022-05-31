<Query Kind="Statements" />

using System;
/*
Instance Constructor: initialize code on a class or struct. (make an instance of a class/struct object)
	- can have the following modifiers
		access modifiers: public, internal, private, protected
		unmanaged code modifiers: unsafe, extern  
*/


Bunny b1 = new Bunny {Name="bo", LikesCarrots=true, LikesHumans=false};	// parameterless constructor
Bunny b2 = new Bunny("buggs") {LikesCarrots=true, LikesHumans=false};	// Object Initalizers
Bunny b3 = new Bunny(n:"sam",l1:true);	// optianal parameters
Console.WriteLine(b3);


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
		width = Width;
		height = Height;
	}
}


/*
Object Initalizers: any accessible fields or properties of an object can be set wia an obj initializer directly after construction
*/
class Bunny
{
	public string Name;
	public bool LikesCarrots;
	public bool LikesHumans;
	
	public Bunny(){}
	public Bunny(string n) {Name = n;}
	
	public Bunny(string n, bool l1 = true, bool l2=false)	// optional paramters
	{
		Name = n;
		LikesCarrots = l1;
		LikesHumans = l2;
	}
}

/*
The this Reference: refers to the instance itsself
	- also useful for disambiguating a local variable or param from a field
*/

public class Dog
{
	public Dog Mate;
	
	public void Marry(Dog partner)
	{
		Mate = partner;
		partner.Mate = this;
	}
}

public class Test
{
	string name;
	public Test(string name){this.name = name;}
}



















