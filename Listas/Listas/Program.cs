using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>();
            nameList.Add("Maria");
            nameList.Add("Alex");
            nameList.Add("Bob");
            nameList.Add("Anna");
            nameList.Insert(2, "Marco");
            foreach (string obj in nameList)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("nameList count: " + nameList.Count);
            string s1 = nameList.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);
            string s2 = nameList.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);
            int pos1 = nameList.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);
            int pos2 = nameList.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            List<string> nameList2 = nameList.FindAll(x => x.Length == 5);

            Console.WriteLine("---------------------");

            foreach (string obj in nameList2)
            {
                Console.WriteLine(obj);
            }
            nameList.Remove("Alex");

            Console.WriteLine("---------------------");

            foreach (string obj in nameList)
            {
                Console.WriteLine(obj);
            }
            nameList.RemoveAll(x => x[0] == 'M');

            Console.WriteLine("---------------------");

            foreach (string obj in nameList)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
