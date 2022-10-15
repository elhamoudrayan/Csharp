using System;

namespace Encryption_affine
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();
            int k,index,plus;
            string encryption = "";
            do
            {
                Console.WriteLine("Give me an int between 0 and 25");
                k = int.Parse(Console.ReadLine());
            } while (k < 0 || k > 25);

            Console.WriteLine("Give me the word to encrypt");
            string enc = Console.ReadLine().ToLower();

            for (int j = 0; j < enc.Length; j++)
            {

                if (Array.IndexOf(alpha, enc[j]) == -1)
                {
                    encryption = encryption + enc[j];
                }
                else
                {
                    plus = Array.IndexOf(alpha, enc[j]) + k;
                    if (plus > 26)
                    {
                        plus = plus - 26;
                        encryption = encryption + alpha[plus];
                    }
                    else
                        encryption = encryption + alpha[plus];
                }
            }

            Console.WriteLine(encryption);
        }
    }
}
