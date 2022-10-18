using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            int k;
            string inds ="" ;
            int[] arr = { 2, 4, 5, 8, 1, 3, 9, 3, 4, 5, 6, 7, 3, 2, 1, 2, 3, 4, 5, 6 };
            Console.Write("what are searching for: ");
            string index = Console.ReadLine();
            for (k = 0; k < arr.Length; k++)
            {
                if (arr[k].ToString() == index)
                    inds += ' ' + k.ToString();
            }
            if (inds == "")
                inds += -1;
            Console.WriteLine("These are the indexes of {0} : {1}", index, inds);
        }
    }
}
