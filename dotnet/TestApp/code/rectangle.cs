using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Enter the length of rectangle:");
    double length = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the width of rectangle:");
    double width = Convert.ToDouble(Console.ReadLine());
    double area = length*width;
    Console.WriteLine("Area of rectangle is: " + area );

  }
}