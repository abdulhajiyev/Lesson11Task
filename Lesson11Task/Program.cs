using System;
using System.Linq;

namespace Lesson11Task
{
    public delegate void Func(string text);

    class MyClass
    {
        public void Space(string str)
        {
            string spaceStr = null;
            foreach (var ch in str)
            {
                spaceStr += ch + "_";
            }

            Console.WriteLine($"Spaced string \"{spaceStr}\"");
        }


        public void Reverse(string str)
        {
            #region LINQ Method

            //var reverseStrLinq = new string(str.Reverse().ToArray());

            #endregion

            #region Method 1 (Currently using this)

            string reverseStr = null;
            for (var i = str.Length - 1; i >= 0; i--)
            {
                reverseStr += str[i];
            }

            Console.WriteLine($"Reversed string \"{reverseStr}\"");

            #endregion

            #region Method 2

            /*
            var newChStr = str.ToCharArray();
            Array.Reverse(newChStr);
            var newStr = new string(newChStr);
            Console.WriteLine($"Reversed string \"{newStr}\"");
            */

            #endregion
        }
    }

    class Run
    {
        public void RunFunc(Func funcDell, string str)
        {
            funcDell.Invoke(str);
        }
    }

    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            var str = Console.ReadLine();
            MyClass cls = new MyClass();
            Func funcDell = new Func(cls.Space);
            funcDell+=cls.Reverse;
            Run run = new Run();
            run.RunFunc(funcDell, str);
        }
    }
}