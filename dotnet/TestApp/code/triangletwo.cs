using System;

class triangletwo {
  public static void Main (string[] args) {
    Console.WriteLine("Enter the base of triangle:");
    double Base = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the height of triangle:");
    double Height = Convert.ToDouble(Console.ReadLine());
    double area = (Base * Height) / 2;
    Console.WriteLine("Area of triangle is: " + area );

  }
}