using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    
    class Program
    {
        public static int Function(int value)
        {
            int result = -1;
            if (value <= 0)
            {
                result = 1;
            }
            else if (value % 2 == 0)
            {
                result = Function(value - 2) * value;
            }
            else
            {
                result = Function(value - 1) * value;
            }
            return result;
        }
        static void Main(string[] args)
        {
            //   Function(4);
            int[][][] arr = new int[3][][];
            arr[0] = new int[][]
            {
                new int[2]{1,2},new int [2]{3,4}
            };

            Console.WriteLine(arr[0][0][1]);

            int[,] arr1 = new int[2, 3];
            int[][] arr2 =new[] { new int[] { 0, 2 } };

            int[] arr3 = new int[2];

            int[] i = new int[]{ 1, 2, 3, 4, 5 };
            double[] k = new double[5];

            Console.ReadLine();

            //總結
            // arr1 為正常的2維陣列 2*3的陣列
            // arr & arr2 是陣列中 再加入陣列  有階層性的陣列
        }
    }
}
