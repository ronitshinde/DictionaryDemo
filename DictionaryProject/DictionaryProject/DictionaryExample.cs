using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryProject
{
    public class DictionaryExample
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        public void DictionaryMethod()
        {
            dictionary.Add("1", "Ronnie");
            dictionary.Add("2", "Messi");
            dictionary.Add("3", "Ronaldo");
            dictionary.Add("4", "Neymar");
            Console.WriteLine(dictionary["1"]);
            Console.WriteLine(dictionary["2"]);
            dictionary["5"] = "Ronaldinho";
            foreach (KeyValuePair<string, string> kvp in dictionary)
            {
                Console.WriteLine("{0} : {1}", kvp.Key, kvp.Value);
            }
            Dictionary<int, string> keyValue = new Dictionary<int, string>();
            keyValue.Add(1, "Ambani");
            keyValue.Add(2, "Birla");
            keyValue.Add(3, "Mahindra");
            //Remove the value
            keyValue.Remove(2);
            foreach (KeyValuePair<int, string> pair in keyValue)
            {
                Console.WriteLine("{0} : {1}", pair.Key, pair.Value);
            }
            if (keyValue.ContainsKey(3))
            {
                keyValue[3] = "Tata";
            }
            foreach (KeyValuePair<int, string> pair in keyValue)
            {
                Console.WriteLine("{0} : {1}", pair.Key, pair.Value);
            }
            //Clear method is used to clear the dictionary.
            keyValue.Clear();
            foreach (KeyValuePair<int, string> pair in keyValue)
            {
                Console.WriteLine("{0} : {1}", pair.Key, pair.Value);
            }
        }
    }
}

