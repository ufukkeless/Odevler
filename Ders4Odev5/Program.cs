using System;
using System.Collections.Generic;

namespace Ders4Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(1, "Ufuk KELEŞ");
            students.Add(2, "Esma KELEŞ");
            Console.WriteLine(students.Count);

            MyDictionary<int, string> students2 = new MyDictionary<int, string>();
            students2.Add(1, "Ufuk KELEŞ");
            students2.Add(2, "Esma KELEŞ");
            Console.WriteLine(students2.Count);


        }
    }
}
