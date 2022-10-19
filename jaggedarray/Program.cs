using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jarray = new int[3][];

            jarray[0] = new int[] { 1,2,3,4,5};
            jarray[1] = new int[] { 10,20,30};
            jarray[2] = new int[] { 100,200 };

            for(int i = 0; i < jarray.Length;i++)
            {
                for(int j = 0; j < jarray[i].Length;j++)
                {
                    Console.Write(" " + jarray[i][j]);
                }
                Console.WriteLine();
            }


        }
    }
}
