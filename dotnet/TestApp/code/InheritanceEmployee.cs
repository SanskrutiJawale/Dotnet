using System;  
   public class InheritanceEmployee  
    {  
       public float salary = 40000;  
   }  
   public class Programmer: InheritanceEmployee  
   {  
       public float bonus = 10000;  
   }  
   class TestInheritance{  
       public static void Main(string[] args)  
        {  
            Programmer p1 = new Programmer();  
  
            Console.WriteLine("Salary: " + p1.salary);  
            Console.WriteLine("Bonus: " + p1.bonus);  
  
        }  
    }