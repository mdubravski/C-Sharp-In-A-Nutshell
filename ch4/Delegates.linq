<Query Kind="Statements" />

/*
	Delegates: an object that knows how to call a method
	Delegate Type: defiens the kind of method that delegate instances can call. Speifically, it defines the methods return and 
				   parameter types 
*/

Transformer t = Square;
Console.WriteLine(t(2));

int Square (int x) => x*x;			// method that is compatable with Transformer delegate

delegate int Transformer (int x);	// delegate

