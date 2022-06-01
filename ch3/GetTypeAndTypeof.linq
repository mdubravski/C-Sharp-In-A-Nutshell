<Query Kind="Statements" />

/*
 Object.GetType: retunrs the type of object at runtime
 	- use on the instance
 typeof Operator: retunrs the type of object statically at compile time 
 	- use on the type name
*/
Point p = new Point();
Console.WriteLine(p.GetType().Name);
Console.WriteLine(typeof (Point).Name);
Console.WriteLine(p.GetType() == typeof(Point));
Console.WriteLine(p.X.GetType());
Console.WriteLine(typeof (Point));


public class Point
{
	public int X {get; set;}
	public int Y {get; set;}
}