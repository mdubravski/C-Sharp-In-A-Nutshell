<Query Kind="Statements" />

using System;
using System.Text;

/*
 Stack: block of memory for storing local variabls and parameters.
 	- grows and shrinks as a method or function is entered and exited
	- ex. each trime Factorial is entered, a new int is allocated on the stack
		  and each time the method exits, tje int is deallocated.
*/

static int Factorial(int x)
{
	if(x==0) return 1;
	return x * Factorial(x-1);
}

/*
 Heap: the memory in whcih objects (i.e., reference type instances) reside.
 	- whenever a new obj is created it is allocated on the heap, and a reference to that object is returned
	- runtime has a grabage collector that periodically deallocated objs from the heap
	- static fields are stored on the heap 
*/

StringBuilder ref1 = new StringBuilder("object1");
Console.WriteLine(ref1); 
// StringBuilder referenced by ref1 id now elligable for GC

StringBuilder ref2 = new StringBuilder("object2");
StringBuilder ref3 = ref2;
// the StringBuilder referenced by ref 2 is NOT elligable for GC