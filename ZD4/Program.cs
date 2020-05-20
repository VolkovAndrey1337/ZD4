using System;
using static System.Convert;
using static System.Console;
using System.Collections;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add('A');
            list.Add(64);
            list.Add('P');
            list.Add(52);
            list.Add('c');
            list.Add(51);
            list.Add(-41);
            list.Add(1);
            list.Add('B');
            list.Add(11);
            list.Add('g');
            list.Add(2);
            list.Add(3);
            list.Add('U');

            ArrayList list2 = new ArrayList();
            WriteLine("Числа: ");
            for (int i = 0; i < list.Count; i++)
            {
                int n = 0;
                string k = list[i] + "";
                bool r = int.TryParse(k, out n); ;

                if (r == false)
                {
                    if (k == k.ToUpper())
                    {
                        list2.Add(list[i]);
                        list.RemoveAt(i);
                    }
                    else list.RemoveAt(i);
                }
            }
            foreach (object o in list)
            {
                WriteLine(o);
            }
            WriteLine("БУКАВЫ: ");
            foreach (object o in list2)
            {
                WriteLine(o);
            }
            ReadLine();
        }
    }
}