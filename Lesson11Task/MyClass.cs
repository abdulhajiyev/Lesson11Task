using System;

namespace Lesson11Task
{
    class MyClass
    {
        public void Space(string str)
        {
            string spaceStr = null;
            for (var i = 0; i < str.Length-1; i++)
            {
                
                spaceStr += str[i] + "_";
                if (i == str.Length-2)
                {
                    spaceStr += str[^1];
                }
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
}