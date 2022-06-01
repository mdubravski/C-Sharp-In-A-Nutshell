<Query Kind="Statements" />

/*
Constructors and Inheritance:
	- a subclass must declare its own construtors
*/
Subclass s = new Subclass(10);
public class Baseclass
{
	public int X;
	public Baseclass(){}
	public Baseclass(int x){this.X = x;}
}

public class Subclass : Baseclass 
{
	public Subclass(int x) : base(x) {} // inheriting ocnstructor from base class 
}