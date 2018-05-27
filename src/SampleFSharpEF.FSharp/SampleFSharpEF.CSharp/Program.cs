using System;
using System.Linq;
using SampleFSharpEF.Model;


namespace SampleFSharpEF.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C# World!");
            var ent = new redmineEntities();
            foreach ( var it in ent.projects.ToList())
            {
                Console.WriteLine(String.Format("{0} : {1}", it.id, it.name));
            }
        }
    }
}
