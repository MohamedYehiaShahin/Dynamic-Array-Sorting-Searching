using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DArray
{
    public class DynmArray
    {
        private int HighestCount = 0, LowestCount = 0;
        private int[] Ints;
        public int numOfHigest()
        {
            int higestGrade = higest();
            for (int i = 0; i < Ints.Length; i++)
            {
                if (Ints[i] == higestGrade)
                {
                    HighestCount++;
                }
            }
            return HighestCount;
        }

        public int numOfLowest()
        {
            int LowestGrade = Lowest();
            for (int i = 0; i < Ints.Length; i++)
            {
                if (Ints[i] == LowestGrade)
                {
                    LowestCount++;
                }
            }
            return LowestCount;
        }
        public DynmArray()
        {
            Ints = new int[20];
        }

        public DynmArray(int size)
        {
            Ints = new int[size];
        }


        public decimal Average()
        {
            int sum = 0;
            for (int i = 0; i < Ints.Length; i++)
                sum += Ints[i];
            decimal avg = sum / Ints.GetLength(0);
            return avg;
        }

        public int higest()
        {
            int higest = Ints[0];
            for (int i = 1; i < Ints.Length; i++)
                if (higest <= Ints[i])
                {
                    higest = Ints[i];
                }
            return higest;
        }

        public int Lowest()
        {
            int lowest = Ints[0];
            for (int i = 1; i < Ints.Length; i++)
                if (lowest >= Ints[i])
                {
                    lowest = Ints[i];
                }
            return lowest;
        }
        public void FillArray()
        {
            Console.WriteLine("-------------------------------------\n" +
                "     Please Fill Grades\n " +
                              "-------------------------------------");
            for (int i = 0; i < Ints.Length; i++)
                Ints[i] = int.Parse(Console.ReadLine()!);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Thanks for Filling Grades Table ... \n" +
                "if you want to add any Grade please choose a or finish choose x:");
            if (Console.ReadLine() == "a")
                RepeatInput();

        }

        private void RepeatInput()
        {
            Resize();
            Ints[Ints.GetUpperBound(0)] = int.Parse(Console.ReadLine()!);
            Console.Write("Choose a to continue adding grade or press any key to show output: ");
            if (Console.ReadLine() == "a")
                RepeatInput();

        }

        private void Resize()
        {
            int[] ints = new int[Ints.Length + 1];
            for (int i = 0; i < Ints.Length; i++)
            {
                ints[i] = Ints[i];
            }

            Ints = new int[ints.Length];
            for (int i = 0; i < ints.Length; i++)
            {
                Ints[i] = ints[i];
            }
        }

        //Sorting Algorithms
        /// <summary>
        /// Sorting the collection integers using bubble sort algorithm
        /// </summary>
        public void BubbleSort()
        {
            int j = Ints.Length;
            while (j > 1)
            {
                for (int i = 0; i < j-1; i++) 
                {
  
                        if (Ints[i] >= Ints[i + 1])
                        {
                            Swap(ref Ints[i], ref Ints[i + 1]);
                        }
                }
                j--;
            }
        }

        public void SelectionSort()
        {
            int current = 0 , min = 0 ;
            for(int i = 0;i< Ints.Length;i++)
            {
                current = i;
                min = i;
                for(int j = i; j < Ints.Length; j++)
                {
                    if(Ints[min] >= Ints[j])
                        min = j;
                }
                if (Ints[current] >= Ints[min])
                    Swap(ref Ints[current],ref Ints[min]);
            }
        }

        /// <summary>
        /// Swaping 2 intger elements
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void Swap(ref int n1 ,ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }
    }
}
