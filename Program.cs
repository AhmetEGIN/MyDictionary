using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDict<int, string> personList = new MyDict<int, string>();
            personList.Add(3, "Ahmet");
            personList.Add(1, "Engin");
            personList.Add(5, "Ali");
            personList.Add(8, "Alp");
            personList.Add(2, "Kağan");
            Console.WriteLine(personList.Count);
            personList.ListPeople();

        }
    }
}
