<Query Kind="Statements" />

/*
 Abstract Classes: a class defiend as abstract can never be instantiated, only its concrete subclasses can be instaninated
 
 Abstract Members: like virtual members except that they don't provide a default implementation
 
 sealed modifier: prevents method or class from being overriden any further
 
 base keyword: allows you to access an overridden function member from the subclass, or calling a base-class constructor
*/

public abstract class Asset
{
	public abstract decimal NetValue {get;}
}

public class Stock : Asset 
{
	public long SharesOwned;
	public decimal CurrentPrice;
	
	public sealed override decimal NetValue => CurrentPrice * SharesOwned;
}
