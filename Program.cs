using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter The limt of the 2D  prime array  ");
            int x = int.Parse(Console.ReadLine());
            Queue<int> mylist = new Queue<int> ();
            for (int i = 2; i <=x * x ; i++)
            { int res =  checkPrime(i);
              if (res==1)
              { mylist.Enqueue(i);}
            }

           int [,] matrix = new int [x*x*x,x*x*x] ;
           for (int row = 0; row <= x; row++)
           {
               for ( int col = 1; col <= 2; col++)
               {
                      if (mylist.Count()==0)
                       { break;}
                        else   
                       matrix[col, row] = mylist.Dequeue();
                       Console.Write("   " + matrix[col, row]);     
               }
               Console.WriteLine();
           } Console.ReadKey();  
        }


        private static int checkPrime(int i)
        {int j;
            for ( j = 2; j <= i; j++)
            {if (i % j == 0)
            {  return 0;  break; } break; 
            }
           return 1;      
         }       
    
    }
}
