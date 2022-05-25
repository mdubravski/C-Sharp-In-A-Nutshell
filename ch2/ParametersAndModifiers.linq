<Query Kind="Statements" />

using System;

// Passing Arguments by Value
int x = 8;
Foo(x); // make a copy of x
Console.WriteLine(x); // x will still be 8

StringBuilder sb = new StringBuilder();
FooSB(sb);
Console.WriteLine(sb.ToString());

// Passing Arguments by Refernece
int y = 8;
FooRef(ref y); // ask FooRef to deal directly with y
Console.WriteLine(y); // y is now 9

string a = "micahel";
string b = "peter";
Swap(ref a,ref b);
Console.WriteLine(a);

/* 
Out Modifier: like ref but 
	- it need not be assigned nefore going into the function
	- it must be assigned when it comes out of a function	
*/
Split("Stevie Ray Vaughn", out string c, out string d);
Console.WriteLine(c);
Console.WriteLine(d);

Split("Stevie Ray Vaughn", out string e, out _); // discarding the 2nd parameter


// In Modifier: like ref except that the arguments' value can NOT be modified by the method

// Params Modifier: allows for the method to accept any number of arguments (must be declared as single dim array)
Console.WriteLine(Sum(1,2,3,4,5));
int Sum(params int[] nums)
{
	int sum = 0;
	foreach(int n in nums)
	{
		sum += n;
	}
	return sum;
}

void Split(string name, out string firstName, out string lastName)
{
	int i = name.LastIndexOf(" ");
	firstName = name.Substring(0,i);
	lastName = name.Substring(i + 1);
}

static void Swap(ref string a, ref string b)
{
	string temp = a;
	a = b;
	b = temp;
}

static void FooRef(ref int p)
{
	p++;
	Console.WriteLine(p);
}

static void Foo(int p)
{
	p++;
	Console.WriteLine(p);
}

static void FooSB(StringBuilder sb)
{
	sb.Append("test");
	sb = null;
}
