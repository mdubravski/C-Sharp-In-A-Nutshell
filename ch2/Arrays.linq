<Query Kind="Statements" />

using System;
/*
 Array: represents a fixed number of variables (called elements)
 		of a given type.
*/

// making arrays
char[] vowels = new char[5];
vowels[0] = 'a';
vowels[1] = 'e';
vowels[2] = 'i';
vowels[3] = 'o';
vowels[4] = 'u';

int[] nums = {1,2,3,4,5,6};

// array indexing
Console.WriteLine(vowels[0]); // first element 
Console.WriteLine(vowels[^1]);  //last element 

// ranges
char[] firstTwo = vowels[..2];
char[] lastTwo = vowels[2..];
char[] middleOne = vowels[2..3];

// multidimensional arrays rectangular or jagged, represent a n-dimendional blaock of memory
int[,] rectangularArray = new int[3,3];
for(int i=0; i<rectangularArray.GetLength(0); i++)
{
	Console.WriteLine();
	for(int j=0; j <rectangularArray.GetLength(1); j++)
	{
		rectangularArray[i,j] = i * 3 + j;
		Console.Write(rectangularArray[i,j]);
	}
}

int[,] matrix = new int[,] 
{
	{1,2,3},
	{4,5,6},
	{7,8,9}
};

// jagged array
int[][] jaggedArray = new int[3][];
int[][] jaggedMatrix = new int[][]
{
	new int[] {1,2,3},
	new int[] {4,5,6,7},
	new int[] {9,10}
};

