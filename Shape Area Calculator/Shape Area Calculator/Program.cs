using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
internal class Program
{
    private static void Main(string[] args)
    {
        float radius = 0;
        double piValue = Math.PI;
        string shape = "";
        double triangle_base = 0;
        double triangle_height = 0;
        double square_length = 0;
        Console.WriteLine("Shape calculator\n");

        Console.WriteLine("Choose a shape");
        shape = Console.ReadLine();

        if (shape == "circle")
        {
            Console.WriteLine("Choose radius ");
            radius = Convert.ToInt32(Console.ReadLine());
            double circle_area = radius * piValue;
            Console.WriteLine("The area of the circle is: " + circle_area);
        }
        else if (shape == "triangle")
        {
            Console.WriteLine("Choose base and triangle_height");
            triangle_base = Convert.ToInt32(Console.ReadLine());
            triangle_height = Convert.ToInt32(Console.ReadLine());
            double triangle_area = triangle_base * triangle_height / 2;
            Console.WriteLine("The area of the triangle is: " + triangle_area);
        }
        else if (shape == "square")
        {
            Console.WriteLine("Choose lenght ");
            square_length = Convert.ToInt32(Console.ReadLine());
            double square_area = Math.Pow(square_length, 2); ;
            Console.WriteLine("The area of the square is: " + square_area);
        }
        else
        {
            Console.WriteLine("Not a figure");
        }
    }
}