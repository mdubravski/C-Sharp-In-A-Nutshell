<Query Kind="Statements" />

/*
 Enums: a special value type that lets you specify a group of named numeric constants
 	- each enum member has an underlying intefral value (int by default)
	- can convert from enum instance to underlying integral value with a cast
*/


// transitions between enum types use the underlying integral values
HorizontalAlignment h = (HorizontalAlignment)BorderSlide.Right;

int i = (int)BorderSlide.Bottom;
BorderSlide slide = (BorderSlide)i;

BorderSlide topSlide = BorderSlide.Top;
bool isTop = (topSlide == BorderSlide.Top); // true

public enum HorizontalAlignment
{
	Left = BorderSlide.Left,
	Right = BorderSlide.Right,
	Center
}

public enum BorderSlide { Left, Right, Top, Bottom }

