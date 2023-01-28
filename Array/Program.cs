using System;
using System.Linq;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] friends1=new string[5];

            friends1[0]="Ali";
            friends1[1]="Abed";
            friends1[2]="Ahmed";
            friends1[3]="mohamad";
            friends1[4]="mahmoud";
        string[] friends2=new string[2] {"Ali","Abed"};
        string[] friends3={"Ali","Abed","kamal","Ahmed","mohamad","mahmoud"};

        var a1=friends3[..2];//returen first two elemnt
        var a2=friends3[2..];//skip first two elemnt
        var a3=friends3[2..4];//returen first 4 elemnt but skip first 2 element
        var a4=friends3[..^2];//skip last two elemnt
        var a5=friends3[^2..];//return last  & first two elemnt
        var a6=friends3[2..^2];//skip last two elemnt

        int[,] multyDimaition1=new int[2,3]{{1,3,5},{4,6,7}};
       int[,] multyDimaition2= {{1,3,5},{4,6,7}};

        var jagged= new int[][]
        {
            new int[]{1,2,3,4,5},
            new int[]{45,7},
            new int[]{7,99,457}
        };
     
            friends1.Print();
            Console.WriteLine("\n----------------------------------------");
            friends2.Print();
               Console.WriteLine("\n----------------------------------------");
            friends3.Print();
                   Console.WriteLine("\n----------------------------------------");
            a6.Print();
            Console.ReadLine();
        }
    }

        public static class Extentions{
             public static void Print<T>(this T[] source){
                 if(!source.Any())
                 {
                     Console.WriteLine("{}");
                     return;
                 }
                 Console.Write("{ ");
                for(int i=0; i<source.Length;i++){
                    Console.Write($"{source[i]}");
                    Console.Write(i<source.Length-1?",":"");
                }
                Console.Write("}");
             }
         }
         }

      
