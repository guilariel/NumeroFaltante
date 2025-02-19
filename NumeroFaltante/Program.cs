using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroFaltante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [0,1];

            Console.WriteLine(MissingNumber(nums));
        }
        public static int MissingNumber(int[] nums)
        {
            HashSet<int> ints = new HashSet<int>(nums);
            int numeroFaltante = 0;
            int max = nums.Max();

            for (int i = 0; i <= max; i++)
            {
                if (ints.Contains(i))
                {
                    if(i == max)
                    {
                        numeroFaltante = max + 1;
                    }
                    continue;
                }
                else
                {
                    numeroFaltante = i;
                    break;
                }

            }

            return numeroFaltante;
        }
    }
}
