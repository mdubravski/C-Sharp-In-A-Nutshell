<Query Kind="Statements" />

/*
 Interfaces: similar to a class but only specifies behavior and does not hold state (data). Consequently
 	 - an interface can only define functions, not fields
	 - interface memebers are implicitly abstract
	 - a class or struct can implement multiple interfaces
*/
ILogger.Prefix = "File Log: ";
((ILogger) new Logger()).Log("Logging!"); // calling default implementation

Widget w = new Widget();
w.Foo();
((I1)w).Foo();
((I2)w).Foo();


IEnumerator c = new Countdown();
while(c.MoveNext())
	Console.Write(c.Current);

internal class Countdown : IEnumerator
{
	int count = 11;
	public bool MoveNext() => count-- > 0;
	public object Current => count;
	public void Reset() {throw new NotSupportedException();}
}

interface I1 {void Foo();}
interface I2 {int Foo();}

public class Widget : I1,I2 
{
	public void Foo()
	{
		Console.WriteLine("I1 Foo");
	}
	
	int I2.Foo()
	{
		Console.WriteLine("Foo I2");
		return 42;
	}
}

public interface IUndoable {void Undo();}

public class TextBox : IUndoable
{
	public virtual void Undo() => Console.WriteLine("TextBox.Undo");
}

public class RichTextBox : TextBox
{
	public override void Undo() => Console.WriteLine("RickTextBox.Undo");
}

// deafult interface memebers
public interface ILogger
{
	void Log(string text) => 
		Console.WriteLine(Prefix + text);
	static string Prefix = "";
}

class Logger : ILogger
{
	
}
