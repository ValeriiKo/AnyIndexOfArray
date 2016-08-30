﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array__Indexator_and_Property_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace AnyIndexOfArray
    {
        class RangeArray
        {
            int[] a;
            public int lowI { get; private set; }  
            public int highI { get; private set; }
            
            public RangeArray(int low, int high)
            {
                if (low > high)
                {
                    Console.WriteLine("Input a correct index of array!\n High index must be more than low!");
                    a = new int[0];
                    Length = 1;
                }
                else
                {
                    high++;
                    a = new int[high - low];
                    Length = high - low;
                    highI = --high;
                    lowI = low;
                }
            }

            public int Length { get; private set; }

            public bool Error { get; private set; }

            //Индексатор для класса
            public int this[int index]
            {
                get
                {
                    if (ok(index))
                    {
                        Error = false;
                        return a[index-lowI];
                    }
                    else
                    {
                        Error = true;
                        return 0;
                    }
                }
                set
                {
                    if (ok(index))
                    {
                        Error = false;
                        a[index-lowI] = value;
                    }
                    else
                    {
                        Error = true;
                    }
                }
            }
            
            //Проверить нахождение индекса в длине массива
            public bool ok(int index)
            {
                if (index >= lowI && index <= highI) return true;
                else return false;
            }


        }
        class Program
        {
            static void Main(string[] args)
            {
                RangeArray Arr = new RangeArray(-5,5);
                Console.WriteLine("Low=-5, High =5, \nArray is");
                Console.WriteLine("Length of array is " + Arr.Length);
                for (int i = -5; i < Arr.Length; i++)
                {
                    Arr[i] = i * 10;
                    if (!Arr.Error) Console.WriteLine("Arr[" + i + "]=" + Arr[i]);
                    else Console.WriteLine("Error in {0} element of array.", i);
                }
                Console.WriteLine("Low=10, High =7, \nArray is");
                RangeArray Arr2 = new RangeArray(10, 7);
                Console.WriteLine("Length of array is " + Arr2.Length);
                for (int i = Arr2.lowI; i <=Arr2.highI; i++)
                {
                    Arr[i] = i * 10;
                    if (!Arr.Error) Console.WriteLine("Arr[" + i + "]=" + Arr[i]);
                    else Console.WriteLine("Error in {0} element of array.", i);
                }
                Console.ReadKey();
            }
        }
    }
}

