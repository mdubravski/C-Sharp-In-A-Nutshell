<Query Kind="Statements" />

/*
 ToString Method: returs a textual representation of a type instance
 	- this method is overwritten by all built in types
*/

int x = 10;
Console.WriteLine(x.ToString());

Panda p = new Panda{Name="Pete"};
Console.WriteLine(p.ToString());

public class Panda
{
	public string Name;
	public override string ToString() => Name;
}