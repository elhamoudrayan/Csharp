using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Msccalc
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string uvalue, ls;
            int numb, str, ntc, A, B, C;
            double delta, x, y;
            do
            {
                
                Console.WriteLine("Choose a number to start your mathematical operation:");
                ls =
                    "1)Solution of a Quadratic Function \n2)Test if the number is palindrome\n3)Test If The Number Is Crossed\n0)Exit";
                Console.WriteLine(ls);
                do
                {
                    uvalue = Console.ReadLine();
                    if (int.TryParse(uvalue, out numb))
                        str = 1;

                    else
                    {
                        str = 0;
                        Console.WriteLine(ls);
                    }
                } while (str == 0);

                ntc = int.Parse(uvalue);

                if (ntc == 1)
                {
                    Console.WriteLine(
                        "You Chose To Calculate The Solution Of A Quadratic Form \n The form is Ax^2 + bx + c = 0");
                    Console.Write("Give me A: ");
                    A = int.Parse(Console.ReadLine());
                    Console.Write("Give me B: ");
                    B = int.Parse(Console.ReadLine());
                    Console.Write("Give me C: ");
                    C = int.Parse(Console.ReadLine());

                    delta = Math.Pow(B, 2) - 4 * A * C;
                    Console.WriteLine("Delta is equal to {0}", delta);
                    if (delta < 0)
                    {
                        Console.WriteLine("Your System Has No Solution In R(The Set of Real Numbers)");
                    }

                    if (delta > 0)
                    {
                        x = (B - Math.Sqrt(delta)) / (2 * A);
                        y = (-B - Math.Sqrt(delta)) / (2 * A);

                        Console.WriteLine("Your Equation Has Two Real Roots x={0} and y={1}", x, y);
                    }

                    if (A == 0 && B == 0 && C == 0)
                    {
                        Console.WriteLine("0 is not even an equation");
                    }

                    if (delta == 0)
                    {
                        x = -B / 2 * A;
                        Console.WriteLine("Your Equation Has A Double Root x={0}", x);
                    }
                    Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                    Console.ReadKey();
                }

                if (ntc == 2)
                {
                    Console.WriteLine(
                        "A number is called palindrome if reading it from left to right is the same as right to left ex:62926");
                    int n, exn, inv;
                    do
                    {
                        Console.WriteLine("Give me a positive int:");
                        n = int.Parse(Console.ReadLine());
                    } while (n < 0);

                    exn = n;
                    inv = 0;
                    while (n > 0)
                    {
                        inv = inv * 10 + n % 10;
                        n = n / 10;
                    }

                    if (inv == exn)
                    {
                        Console.WriteLine("Your number {0} is palindrome", exn);
                    }
                    else
                    {
                        Console.WriteLine("Your number {0} is NOT palindrome", exn);
                    }
                    Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                    Console.ReadKey();                    
                }

                if (ntc == 3)
                {
                    Console.WriteLine("A number is called crossed if the sum of its digits is equal to their product");
                    int n, sum, pr, mod;
                    do
                    {
                        Console.WriteLine("give me a positive integer:");
                        n = int.Parse(Console.ReadLine());
                    } while (n <= 0);

                    sum = 0;
                    pr = 1;
                    ;
                    while (n != 0)
                    {
                        mod = n % 10;
                        n = n / 10;
                        pr = pr * mod;
                        sum = sum + mod;

                    }

                    if (sum == pr)
                    {
                        Console.WriteLine("Your number is crossed");
                    }
                    else
                    {
                        Console.WriteLine("Your number is not crossed");
                    }

                    Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                    Console.ReadKey();
                }
            } while (ntc != 0);
        }
    }
}