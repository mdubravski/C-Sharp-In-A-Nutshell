<Query Kind="Statements" />

/*
	Delegates: an object that knows how to call a method
	Delegate Type: defiens the kind of method that delegate instances can call. Speifically, it defines the methods return and 
				   parameter types 
*/

Transformer t = Square;
Console.WriteLine(t(2));

int[] values = {1,2,3,4};
Transform(values, Square);		// hook in Square method
values.Dump();

void Transform(int[] values, Transformer t)
{
	for(int i=0; i<values.Length; i++)
		values[i] = t(values[i]);
	
}

int Square (int x) => x*x;			// method that is compatable with Transformer delegate
int Cube (int x) => x*x*x;

delegate int Transformer (int x);	// delegate

