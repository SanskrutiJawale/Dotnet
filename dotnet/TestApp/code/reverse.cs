using System;
class Array{
    static void Main(String[] args){
        int[] num = new int[5];
        int len = num.Length;
        
        for(int i=0;i<num.Length;i++){
            num[i] = Convert.ToInt32(Console.ReadLine());
        }
        for(int i=len-1;i>=0;i--){
            Console.Write(num[i]);
        }

    }
}