using System;

namespace Lesson11Task
{
    class MyClass
    {
        public void Space(string str)
        {
            for (int i = 1; i < str.Length; i++)
            {
                str = str.Insert(i, "_");
                i++;
            }
            Console.WriteLine($"Spaced string \"{str}\"");
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
}