using System;
namespace arr_matrices{
class arr_matrices{
    static void Main(string[] args){
        int[,] arr1={{1,2,3},{5,2,3},{1,2,1}};
        int[,] arr2={{1,2,3},{5,2,3},{1,2,1}};

        int n=3,m=3;
        int[,] add=new int[n,m];
        int[,] sub=new int[n,m];
        int[,] mult=new int[n,m];
        int[,] div=new int[n,m];
        int[,] mod=new int[n,m];

        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                add[i,j]=arr1[i,j]+arr2[i,j];
                sub[i,j]=arr1[i,j]-arr2[i,j];
                mult[i,j]=arr1[i,j]*arr2[i,j];
                div[i,j]=arr1[i,j]/arr2[i,j];
                mod[i,j]=arr1[i,j]%arr2[i,j];
            }
        }
        Console.WriteLine("Addition ::::\n");
        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                Console.WriteLine(add[i,j]);
            }
            Console.WriteLine();
        }
        
        Console.WriteLine("\nSubtraction ::::\n");
        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                Console.WriteLine(sub[i,j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nMultiplication ::::\n");
        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                Console.WriteLine(mult[i,j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nDivision ::::\n");
        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                Console.WriteLine(div[i,j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nMod Operation ::::\n");
        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                Console.WriteLine(mod[i,j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nThank You .... !");
    }
}
}