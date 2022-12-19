using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE5_20210140125_KELOMPOK4
{
    class Program
    {
        int ricco, arisdy, max = 5;
        int[] queques_array = new int[5];

        public Program()
        {
            ricco = -1;
            arisdy = -1;
        }

        public void insert(int element)
        {
            if ((ricco == 0 && arisdy == max -1) || (ricco == arisdy +1))
            {
                Console.WriteLine("\nQueue overlow\n");
                return;
            }
            if (ricco == -1)
            {
                ricco = 0;
                arisdy = 0;
            }
            else
            {
                if (ricco == max - 1)
                    ricco = 0;
                else;
                ricco = ricco + 1;
            }
            queques_array[ricco] = element;
        }
        static void Main(string[] args)
        {
        }
    }
}
