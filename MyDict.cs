using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDict<TKey,TValue>
    {
        TKey[] number;
        TValue[] name;
        TKey[] tempNumber;
        TValue[] tempName;
        public MyDict()
        {
            number = new TKey[0];
            name = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            if(Array.IndexOf(number, key) == -1)
            {
                tempNumber = number;
                number = new TKey[number.Length + 1];
                tempName = name;
                name = new TValue[name.Length + 1];
                for (int i = 0; i < tempName.Length; i++)
                {
                    number[i] = tempNumber[i];
                    name[i] = tempName[i];

                }
                number[number.Length - 1] = key;
                name[name.Length - 1] = value;
                Console.WriteLine("The person has been added to the list.");
            }
            else
            {
                Console.WriteLine("There is already a person with same nummber.");
            }
        }

        public int Count
        {
            get { return number.Length; }    
        }
        public void ListPeople()
        {
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine("Name: {0} Number: {1}", name[i],number[i]);
            } 
        }
    }
}
