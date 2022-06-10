<Query Kind="Statements" />

/*
 structs: similar to a class but with the following differences,
 	- a struct is a value type, whereas a class is a reference type
	- a struct does not support inheritance (other than implicitly deriving from System.Value)
	- can have all the members that a class can except for finializer
	- can not have modifiers virtual, abstract, protected
*/
Point p1 = new Point(1,2);
Point p2 = default;			// calling default constructor (x=0,y=0)


struct Point
{
	int x,y;
	public Point(int x, int y) {this.x=x; this.y=y;}
}