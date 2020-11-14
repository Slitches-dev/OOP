using System;
using System.Collections.Generic;
using System.Text;

namespace LR4
{
    class Rus_Angl
    {
        private Dictionary<string, List<string>> dictionary;

        public Rus_Angl()
        {
            dictionary = new Dictionary<string, List<string>>();
        }
        public void Add(string str1, string str2)
        {
            if (dictionary.ContainsKey(str1)) dictionary[str1].Add(str2);
            else dictionary.Add(str1, new List<string> { str2 });
        }
        public void Del(string str)
        {
            if (dictionary.ContainsKey(str)) dictionary.Remove(str);
        }
        public void Del(string str1, string str2)
        {
            if (dictionary.ContainsKey(str1) && dictionary[str1].Contains(str2)) dictionary[str1].Remove(str2);
        }
        public void Print(string str)
        {
            if (dictionary.ContainsKey(str))
            {
                Console.Write(str + " = ");
                Console.WriteLine(string.Join(" ", dictionary[str]));
            }
            else Console.WriteLine("не знаю такого слова " + str);
        }
    }
}
