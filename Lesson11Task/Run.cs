namespace Lesson11Task
{
    class Run
    {
        public void RunFunc(Func funcDell, string str)
        {
            funcDell.Invoke(str);
        }
    }
}