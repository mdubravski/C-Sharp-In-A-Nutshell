<Query Kind="Statements" />

/*
 Boxing: the act of converting a value type instance toa reference type instance
 	- copies the value type instance into a new object 
 Unboxing: the act of converting a reference type instance to a value type instance
 	- copies the contents of the object back into a value-type instance
*/

int x =9; 
object obj = x; // boxing

int y = (int)obj; // unboxing