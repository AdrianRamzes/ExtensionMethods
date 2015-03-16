using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Universal;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            3.Times(() => Console.WriteLine("I Love C#"));

            int.MaxValue.Times((i) => Console.WriteLine(i + " is " + (i % 2 == 0 ? i + "even" : "odd")));

            int? someNullableObject = null;

            if (someNullableObject.IsNull())
            {
                //TODO: something
            }

            object[] array = new object[5];
            array.ForEach((o) => Console.WriteLine(o.IsNull() ? "null" : "not null"));

            array.Length.Times((o) => Console.WriteLine(o.IsNull() ? "null" : "not null"));

            "THE END".ForEach((c) => { });
        }
    }
}
