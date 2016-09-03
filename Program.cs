using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociableArray
{
    class AssArr
    {
        string [] a;
        char[] k;
        int i = 0;
        int l;
        public AssArr (int am)//конструктор динамического массива
        {
            if (am > 0) a = new string[am];
            else Console.WriteLine("Кол-во элементов должно быть больше нуля.");
            k = new char[am];
            l = am;
        }


        public string this[char key]
        {
            get// вызов элемента массива по ключу
            {
                for (int j = 0; j < l; j++)
                {
                    if (k[j] == key)
                    {
                        i = j;
                        break;
                    }
                }
                 return a[i];
            }
            set//присваивание значений по ключу
            {
                
                k[i] = key;
                a[i] = value;
                i++;
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            AssArr F = new AssArr(3);
            F['a'] = "Hello!";
            F['b'] = "I";
            F['c'] = "5";
            Console.WriteLine("F['a']=" + F['a'] + "\nF['b']=" + F['b'] + "\nF['c']=" + F['c']+ "\nF['b']=" + F['b']);
            Console.ReadKey();
        }
    }
}
