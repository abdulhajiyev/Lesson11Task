using System;

namespace Lesson11Task
{
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