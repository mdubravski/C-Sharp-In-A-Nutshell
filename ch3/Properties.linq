<Query Kind="Statements" />

/*
 Properties: properties look like fields froim the outside, but internally they contain logic, like methods.
 	- declared like a field but with get/set block added
	- allow the following modifiers
		static modifier = static
		access modifier = public, internal, private, protected
		inheritance modifier = new, virtual, abstract, override, sealed
		unmanaged code modifiers = unsafe, extern
 	- a property is read-only if there is only a get accessor, and write-only if there is only a set accessor 
		- can also be written more tersly using expression-bodied principals
	- automatic property = terse way to make a property that reads and writes to a private field of the same name
*/

public class Stock
{
	decimal currentPrice, sharesOwned; // the private backing field
	
	public decimal CurrentPrice	// property
	{
		get {return currentPrice;}
		set {currentPrice = value;}
	}
	
	public decimal Worth // expression bodied property
	{
		get => currentPrice * sharesOwned;
		set => sharesOwned = value / currentPrice;
	}
	
	public decimal CurrentPriceAutomatic {get; set;} = 123; // automatic property with an initalizer
	
}

public class Foo
{
	private decimal x; 
	public decimal X // property with different access modifiers for acccessors
	{
		get	{return x;}
		private set {x = Math.Round(value,2);}
	}
}

/*
 init-only settets: act like read-only properties, except they can also be set via an object initializer
*/
public class Note
{
 public int Pitch {get; init;} = 20;
 public int Duration {get; init;} = 100;
}