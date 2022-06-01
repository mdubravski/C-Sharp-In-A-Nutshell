<Query Kind="Statements" />

/*
 Indexers : provide a  natural syntax for accessing elements in a class or struct that enncaousulate a list or dictionary of values 
 	- the string class has an indexer that lets you access each of its char values by an int index
*/

Sentance s = new Sentance();
Console.WriteLine(s[^1]);
Console.WriteLine(s[1..]);

class Sentance
{
	string[] words = "The quick brown fox.".Split(" ");
	
	// making an indexer
	//public string this [int wordNum]
	//{
	//	get {return words[wordNum];}
	//	set {words[wordNum] = value;}
	//}
	
	public string this [Index index] => words[index];	// index by indices
	public string[] this [Range range] => words[range];	// index by range
}