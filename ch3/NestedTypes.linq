<Query Kind="Statements" />

/*
 Nested Types: a nested type is declared within the scope of another type
 	- can access the enclosiung type's private members and everything else the enclosing type can access
	- can decale it with full range of access modfifers
	- default accessibility is private
	- accessing a nested type from outside the enclosing type requires qualification with the enclosing types name
*/

int r = (int)TopLevel.Color.Red; // must access nested members via top level class

public class TopLevel
{
	static int x;
	public class Nested // nested class
	{
		static void Foo() {Console.WriteLine(TopLevel.x);}
	}	
	public enum Color {Red, Blue, Tan}	// nested enum
}