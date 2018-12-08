using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlagramControl
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;

            Console.Write("First Word => ");
            a = Console.ReadLine();


            Console.Write("Second Word => ");
            b = Console.ReadLine();

            Console.Clear();

            bool isAnagram = false;

            int needCount = 0;

            if (a.Length != b.Length)
                needCount += (a.Length - b.Length) < 0 ? (a.Length - b.Length) * -1 : (a.Length - b.Length) * 1;

            for (int i = 0; i < a.Length; i++)
            {

                if (!b.Contains(a[i]) && !b.StartsWith(Convert.ToString(a[i])) && !b.EndsWith(Convert.ToString(a[i])))
                {
                    needCount++;
                }
                else
                {
                    b = b.Replace(a[i].ToString(), "");
                }
            }

            if (needCount == 0)
                isAnagram = true;


            if (isAnagram)
                Console.Write("These words already alagrams.");
            else
                Console.Write($"You need {needCount} word for anagram");


            Console.ReadKey();
        }
    }
}
