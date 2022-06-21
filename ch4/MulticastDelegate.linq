<Query Kind="Statements" />

/*
 Multicast Delegate: a delegate instance can reference not just a single method but also a list of target methods
 	- += and -= operators add combine delegate instances
*/

ProgressReporter p = WriteProgressToConsole;
p += WriteProgressToFile;
Util.HardWork(p);


void WriteProgressToConsole(int percentComplete) => System.Console.WriteLine(percentComplete);
void WriteProgressToFile(int percentComplete) => System.IO.File.WriteAllText("progress.txt", percentComplete.ToString());

public delegate void ProgressReporter (int percentComplete);

public class Util
{
	public static void HardWork(ProgressReporter p)
	{
		for(int i=0; i<10; i++)
		{
			p(i*10);								// invoke delegate
			System.Threading.Thread.Sleep(100);		// simulate hardwork
		}
	}
}