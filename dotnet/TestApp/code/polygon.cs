using System;

class polygon {
  public static void Main (string[] args) {
    Console.WriteLine("Enter the number of sides of polygon:");
    double n = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the length of polygon:");
    double length = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the radius of polygon:");
    double radius = Convert.ToDouble(Console.ReadLine());
    double area = (n/2)*length*radius;
    Console.WriteLine("Area of polygon is: " + area );

  }
}