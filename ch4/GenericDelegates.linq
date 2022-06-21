<Query Kind="Statements" />

/*
  Generic Delegate Types: 
*/

int[] values = {1,2,3};
Util.Transform(values, Square);
values.Dump();


int Square (int x) => x*x;

public class Util
{
	public static void Transform<T>(T[] values, Transformer<T> t)
	{
		for(int i=0; i<values.Length;i++)
			values[i]=t(values[i]);	
	}
}

public delegate T Transformer<T> (T arg);