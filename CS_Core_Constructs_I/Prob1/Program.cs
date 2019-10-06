/*
Author: <Daniel Davidson>
Date:   <10/04/2019>
CTEC 135: Microsoft Software Development with C#

<Solution Name>

<Problem description from README.md file. Make sure the comment text is 
reformatted to fit 1-80 column display, with appropriate indentations to 
make it readable>

Example:
Prob 1: Prob 1: Variables and Printing

* region 1: variable declarations

    page 18 in Troelsen shows two different ways to declare int variables. 
    page 71 shows a third way using the "new" keyword.

    In this section declare three different double variables using each of 
    the three type declarations.
...

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Region 1

            /*
            double y = 15.75; 

             */

            int i = 13.75;
            system.Int32 y = 15.3256;
            bool e = new bool(12.3);

            // Region 2
            
            byte valy = 1_2_9;
            Console.WriteLine();

            short j = 12_98_5;
            Console.WriteLine();

            int x = 54_776;
            Console.WriteLine();

            long v = 99_432;
            Console.WriteLine();

            float on = 004_443;
            Console.WriteLine();

            double down = 99954_004;
            Console.WriteLine();

            decimal g = 00033_443;
            Console.WriteLine();

            //Region 3 Max Min Values 

            byte a = 12;
			    
            Console.WriteLine("byte\tA = {0}\t{1}\t{2}\t{3}", a, typeof(byte), byte.MaxValue, byte.MinValue);


        }
    }
}
