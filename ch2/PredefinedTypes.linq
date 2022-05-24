<Query Kind="Statements">
  <Connection>
    <ID>54bf9502-9daf-4093-88e8-7177c12aaaaa</ID>
    <NamingService>2</NamingService>
    <Persist>true</Persist>
    <Driver Assembly="(internal)" PublicKeyToken="no-strong-name">LINQPad.Drivers.EFCore.DynamicDriver</Driver>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\ChinookDemoDb.sqlite</AttachFileName>
    <DisplayName>Demo database (SQLite)</DisplayName>
    <DriverData>
      <PreserveNumeric1>true</PreserveNumeric1>
      <EFProvider>Microsoft.EntityFrameworkCore.Sqlite</EFProvider>
      <MapSQLiteDateTimes>true</MapSQLiteDateTimes>
      <MapSQLiteBooleans>true</MapSQLiteBooleans>
    </DriverData>
  </Connection>
  <RuntimeVersion>6.0</RuntimeVersion>
</Query>

using System;

Console.WriteLine(FeetToInches(2));
SayHello();

int FeetToInches(int feet)
{
	return 12 * feet;
}

void SayHello()
{
	Console.WriteLine("Hello World!");
}

// this is a single line comment

/*
This is a
multi-line comment
*/

const int year = 2022;

string name = "michael dubravski";
string upperName = name.ToUpper();
Console.WriteLine(upperName + year.ToString());

int x = 3000;
bool lessThanAMile = x < 5280;
if(lessThanAMile) Console.WriteLine("This will print!");
