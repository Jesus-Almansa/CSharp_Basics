// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
var testVar = "noob";

Console.WriteLine("Hello " + testVar);
Console.WriteLine("Espabila " + testVar);
Console.WriteLine("Tonto " + testVar);

Console.WriteLine("------------");
// Variables
int a = 1;
int b = 2;
float pi = 3.14f;
float r = 0.5f;
string c = "caraculo";
char d = 'a';
Console.WriteLine("Circle area " + pi * r);

// Cuidado con el tipo de dato
Console.WriteLine(7 / 2); // da 3
Console.WriteLine(7.0 / 2.0); // da 3.5

// Incrementors += , -= , *=

int incrementor = 1;
Console.WriteLine("Incrementor " + incrementor);
incrementor += 1;
Console.WriteLine("Incrementor " + incrementor);

// String to int

string value = "55s5";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine("Success: " + result);
}
else
{
    Console.WriteLine("Failure.");
}