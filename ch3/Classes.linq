<Query Kind="Statements" />

/*
Class: most common reference type. Classes can be further modified by, 
	- Preceding the keyword class with attributes and class modifiers (public, internal, abstract, seal	ed, static, unsafe, and partial)
	- Following your class name with Generic type parameters and constraints, a base class, and paramet	ers.
	- Within the braces, adding class members. (methods, properties, fields, indexers, events, construc	tors, overloaded operators, nested types, and a finalizer)
*/

// most basic class definition
class MyClass{}

/*
Field: variables that are members of a class or struct
	- can have the following modifiers:
		static modifier = static
		access modifier = public, internal, private, protected
		inheritance modifier = new
		unsafe code modifier = unsafe
		readonly modifier = readonly (prevents field from being modified after construction)
		threading modifier = volatile
	- naming converntions for private fields:
		camelCase or _camelCase

*/ 
class Octopus
{
	string name;			// field
	public int age = 10;	// field
	static readonly int eyes = 2,
						legs = 8;
	private string _privateField;
}

/*
Constant: a constant is evaluated statically at compile time, and the comipler literally substitutes its value whenever used. Can be bool, char, string, or any numeric or enum type.
	- declared with const keyword and must be initialized
*/

public class ConstTest
{
 public const string Message = "Hello World!";
 
 // cosntatns can also be declared local to a method
 void Test()
 {
  	const double TwoPI = System.Math.PI * 2;
 }
}

/*
Method: performs an action from a series of statements
	- methods can have the following modifiers:
		static modifier: static
		access modifier: public, internal, private, protected
		inheritance modifier: new, virtual, abstract, override, sealed
		partial method modififer: partial
		unmanaged code modifier: unsafe, extern
		asynchronous code modifier: async
	- methods can be overloaded (multipe methods with same name, different params and return type)
*/


public class MethodTest
{
	// expression-bodied methods (arrow functions)
	int Foo(int x) {return x * 2;}
	double Foo(double x) => x*2;					// method overloading
	void Foo(string x) => Console.WriteLine(x);		// method overloading
	
	// local method (methods defiend within method)
	public void WriteCubes()
	{
		Console.WriteLine(Cube(3));
		Console.WriteLine(Cube(4));
		Console.WriteLine(Cube(5));
		
		int Cube(int x) => x*x*x; // local method
	}	
}