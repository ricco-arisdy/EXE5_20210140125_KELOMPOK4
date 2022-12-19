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

        public void delete()
        {
            if (ricco == -1)
            {
                Console.WriteLine("Queue underflow\n");
                return;
            }
            Console.WriteLine("\n The element deleted from the queue is: " + queques_array[ricco] + "\n");

            if (ricco == arisdy)
            {
                ricco = -1;
                arisdy = -1;
            }
            else
            {
                if (ricco == max - 1)
                    ricco = 0;
                else
                    ricco = ricco + 1;
            }
        }

        public void display()
        {
            int ricco_position = ricco;
            int arisdy_position = arisdy;

            if (ricco == -1)
            {
                Console.WriteLine("Queue is Empty\n");
                return;
            }
            Console.WriteLine("\nElement in the queue are............\n");
            if (ricco_position <= arisdy_position)
            {
                while (ricco_position <= arisdy_position)
                {
                    Console.Write(queques_array[ricco_position] + " ");
                    ricco_position++;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
