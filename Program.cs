using System;

namespace DI_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            tower t = new tower("blue on black");
            cantoi c = new cantoi("a little bit off");
            ShowMesg sm = new ShowMesg(c);
         }
    }
}
