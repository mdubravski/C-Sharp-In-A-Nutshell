<Query Kind="Statements">
  <RuntimeVersion>6.0</RuntimeVersion>
</Query>

using System;
using Animals;

UnitConverter feetToInches = new UnitConverter(12);
Console.WriteLine(feetToInches.Convert(2));

Panda p1 = new Panda("Michael");
Panda p2 = new Panda("Peter");
Console.WriteLine(Panda.Population);


public class UnitConverter
{
	int ratio;								// field
	
	public UnitConverter(int unitRatio)		// constructor
	{
		ratio = unitRatio;
	}
	
	public int Convert(int unit)
	{
		return unit * ratio;				// method
	}
}

namespace Animals
{
	public class Panda
	{
		public string Name;
		public static int Population;
		
		public Panda(string n)
		{
			Name = n;
			Population++;
		}
	}
}