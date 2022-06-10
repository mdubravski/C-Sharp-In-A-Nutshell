<Query Kind="Statements" />

/*
 Access Modifiers: keywords used to limit type or type members accissibility to other types and assemblies
 	- public: fully accessible, this is the impicit assembly for memebers of an enum or itnerface
	- internal: accessible only within the containing assemblies or friend assemblies, default for non nested types
	- private: accessible only within the containing type, default for members of class or struct 
	- protected: accessible only within the containing type or assemblies
	- protected internal: the union of protected and internal accessibility. A member that is protected internal is accesible two ways 
	- private protected: the intersection of protected and interal accessibility. A member tgat is private protected is accessible only within the containing type, or subclasses that reside in the same assembly
*/

// examples

// Class2 is accessible from oputside its assembly, Class2 is not
class Class1{} // interal (default)
public class Class2{}

// ClassB exposes field x to other types in the same assembly 
class ClassA{int x;} // x is private (default)
class ClassB{internal int x;}

// functions within Subclass can call Bar but not Foo
class Baseclass
{
	void Foo(){} // Foo is private (default)
	protected void Bar(){}
}

class Subclass : Baseclass
{
	void Test1(){Foo();} // error - can not access Foo
	void Test2(){Bar();}
}