using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> stringList = new List<string>()
            {
                 "C# Tutorials",
                 "VB.NET Tutorials",
                 "Learn C++",
                 "MVC Tutorials" ,
                 "Java"
            };

            // using query syntax
            var result = from s in stringList
                where s.Contains("Tutorials")
                select s;

            // using method syntax
            // method syntax = .extension methods(lambada expressions)
            var result2 = stringList.Where(s => s.Contains("Tutorials"));
            foreach (var str in result2)
            {
                Console.WriteLine(str);
            }

        }
    }
}
