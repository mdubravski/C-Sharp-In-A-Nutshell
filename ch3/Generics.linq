<Query Kind="Statements" />

/*
 Generics: express reuseability with a 'template' that contains 'placeholder' types
 	- can increase type saftey and reduce casting and boxing
	- generic type: declares type parameters -- placeholder types to be filled in by the consumer of the genric type, which supplies the type arguments
*/

// generic method using a constraint 
static T Max<T> (T a, T b) where T : IComparable<T>
{
	return a.CompareTo (b) > 0 ? a : b;
}


// generic method 
static void Swap<T> (ref T a, ref T b)
{
	T temp = a;
	a = b;
	b = temp;
}

// implementing Stack class with type of int
Stack<int> intStack = new();	// closed type
intStack.Push(5);
intStack.Push(10);
Console.WriteLine(intStack.Pop());


// defining a generic Stack class with generic type T
public class Stack<T>	// open type
{
	int position;
	T[] data = new T[100];
	public void Push(T obj) => data[position++] = obj;
	public T Pop() => data[--position];
}


