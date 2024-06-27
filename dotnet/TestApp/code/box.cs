using System;
namespace sans{
 class box{
    static void Main(string [] args){
        int num=32;
        object obj=num;
        num=23;
        Console.WriteLine("value of number is num{0}",num);
        Console.WriteLine("value of object is obj{0}",obj);
    }
 }
}