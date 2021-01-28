using MyDictionary;
using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");


            foreach (var item in dictionary._keys)
            {
                Console.WriteLine(item + " " + dictionary.GetValue(item));
            }

        }
    }
}