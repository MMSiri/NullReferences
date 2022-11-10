using System;

namespace NullReferences
{
    class Program
    {
        static void Main(string[] args)
        {
            Guy guy;
            guy = new Guy(12,"flob");
            Console.WriteLine("guy.Name is {0} letters long", guy.Name.Length);

        }
    }
}
