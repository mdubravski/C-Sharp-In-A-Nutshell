<Query Kind="Statements" />

using static Asset;
/*
 Casting and Reference Conversion: a new reference is logically created that points to the same obj
 	- implicitly upcast to a base class reference (always succeeds)
	- explicitly downcast to a subclass reference (succeeds only if the obj is suitibly typed)
*/
Stock aapl = new Stock();
Asset a = aapl;			// upcast
Stock s = (Stock)aapl;	// downcast

/*
 The as operator: performs a downcast that evaluated to null (rather than throwing an exception)
*/
Asset b = new Asset();
Stock f = b as Stock; // f os null; no exception thrown

/*
 The is operator: tests whether a variable matches a pattern
*/
if (f is Stock) Console.WriteLine(((Stock)f).SharesOwned);
if(aapl is Stock d) Console.WriteLine(d.SharesOwned);


/*
 Inheritance: a class can inherit from another class to extend or customize the origional class.
 	- a class can only inherit from a single class but can itself be inherited by many classes 
*/
Stock msft = new Stock {Name="Microsoft", SharesOwned=1000};
House secondHome = new House {Name="Second Home", Mortgage=250000};

/*
 Polymorphism: references are polymorphic. This means a variabnle of type x can refer to an object that subclasses x.
*/
Display(msft);
Display(secondHome);

public class Asset // super-class
{
	public string Name;
	
	public static void Display(Asset a)
	{
		System.Console.WriteLine(a.Name);
	}
	
	public virtual decimal Liability => 0;	// expression-bodied property; can be overwritten by subclasses
	
	public virtual Asset Clone => new Asset {Name = Name};
}

public class Stock : Asset // sub-class
{
	public long SharesOwned;
	public override Stock Clone => new Stock {Name=Name, SharesOwned=SharesOwned};
}

public class House : Asset // sub-class
{
	public decimal Mortgage;
	public override decimal Liability => base.Liability + Mortgage; // base keyword
	public override House Clone => new House {Name=Name, Mortgage=Mortgage};
}





