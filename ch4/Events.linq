<Query Kind="Statements" />

/*
	Events: a construct that exposes just the subset of delegate features required for the broadcasters/subscriber model.
			The main purpose of events is to prevent subscribers from interfering with one another
	Broadcaster: is a type that contains a delegaste field. Decides when to broadcast, by invoking a delegate
	Subscriber: method target recipients. Decides when to start and stop listening by calling '+=' and "-=" on the broadcasters
				delegate. Does not know about or interfear with other subscribers
*/

	// delegate defintion 
public delegate void PriceChangedHandler (decimal oldPrice, decimal newPrice);

public class Stock
{
	string symbol;
	decimal price;
	
	private Stock(string symbol) => this.symbol = symbol;
	
	public event PriceChangedHandler PriceChanged;
	
	public decimal Price
	{
		get => Price;
		set
		{
			if(price == value) return;			// exit if nothing has changed
			decimal oldPrice = price;
			price = value;
			if(PriceChanged != null)			// if invocation list not empty, fire event 
				PriceChanged (oldPrice, price);	
		}
	}
}

public class Broadcaster
{
	// event declaration
	public event PriceChangedHandler PriceChanged;
}