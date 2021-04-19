using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace การบ้านครั้งที่4_ข้อ1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            check(input);                                                                  
            PrintTriangle(input);       
            Console.ReadLine();
           
        }


        static bool check(int input)  
        {

            
            if(input<0)
            {
                
                Console.WriteLine("Invalid Pascal’s triangle row number.");
                int input2 = int.Parse(Console.ReadLine());
                input = input2;
                if (input>=0)
                {

                    PrintTriangle(input);
                }
                
                loopCheck(input);
                               
            }
                       
            return true;
        }

        static bool loopCheck(int input)
        {
            do
            {

                check(input);
               
            } while (input >= 0);
            
            return true;
        }

        static void PrintTriangle(int input)
        {
            
            int NoOfRow = input;
            int number = 1;
            
                for (int i = 0; i <= NoOfRow; i++)
                {

                    number = 1;
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(number + " ");
                        number = number * (i - j) / (j + 1);

                    }
                    Console.WriteLine();
                }
            
        }


        




    }
}
