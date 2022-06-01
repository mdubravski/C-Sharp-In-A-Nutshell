<Query Kind="Statements" />

/*
 The object Type: object is the ultimate base class for all types (any type can be upcast to object).
*/

Stack s = new Stack();
s.Push(1);
s.Push(2);
s.Push(3);
s.Push(new int[3]);
s.Push("Hello");
s.Push('@');

for(int i=0; i<s.length; i++)
{
	Console.WriteLine(s.Pop());
}

public class Stack
{
	int position;
	public int length;
	object[] data = new object[10];
	public void Push(object obj) 
	{
		data[position++] = obj;
		length++;	
	}
	public object Pop() 
	{
		length--;
		return data[--position];
	}
}