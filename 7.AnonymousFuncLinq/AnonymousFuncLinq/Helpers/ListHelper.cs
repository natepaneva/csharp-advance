using System;
using System.Collections.Generic;

namespace AnonymousFuncLinq.Helpers
{
    public static class ListHelper
    {
        public static void PrintItems<T>(this List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }


        //public static void PrintEntities<T>(this List<T> list)
        //{
        //    Console.WriteLine($"Printing {list[0].GetType().Name}s...");
        //    Console.WriteLine("-----------------------");
        //    foreach (T item in list)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.WriteLine("-----------------------");
        //}
    }
}
