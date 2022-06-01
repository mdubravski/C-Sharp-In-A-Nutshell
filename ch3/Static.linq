<Query Kind="Statements" />

/*
 Static Constructors:executes once per type rather than once per instance. A type can define only 1 static constructor. 	- must be parameterless and have the same name ass the type
 	- only modifiers allowerd are unsafe and extern
*/

class Test
{	
	static Test() {Console.WriteLine("Type Initialized");}
}

/*
 Static Classes: a class marked static cannot be iinstantiated or subclassed and must be composed soley of static members
 	- ex. System.Console, System.Math
*/