using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TestingCode
{
    internal class Program
    {
        static List<Dictionary<int, string>> postingList1 = new List<Dictionary<int, string>>();
        static List<Dictionary<int, string>> postingList2 = new List<Dictionary<int, string>>();
        static List<Dictionary<int, string>> anwser = new List<Dictionary<int, string>>();
        static List<Dictionary<int, string>> Anwser()
        {
            /*int index = 0;
            while (postingList1[index] != null && postingList2[index] != null)
            {
                if (postingList1[index].Where)
                {
                    anwser.Add(postingList1[index]);
                }else if (postingList1[index].Keys < postingList2[index].Keys)
                {

                }
            }*/

            return anwser;
        }
        static void Main(string[] args)
        {
            /*Dictionary<int, string> p1 = new Dictionary<int, string>
            {
                { 1, "a" },
                { 2, "b" },
                { 3, "c" }
            };

            postingList1.Add(p1);

            Dictionary<int, string> p2 = new Dictionary<int, string>
            {
                { 1, "a" },
                { 2, "b" },
                { 3, "c" }
            };

            postingList2.Add(p2);*/

            /*// Define the first list
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };

            // Define the second list
            List<int> list2 = new List<int> { 3, 4, 5, 6, 7 };

            // Find the intersection of the two lists
            IEnumerable<int> intersection = list1.Intersect(list2);

            // Print the intersecting elements
            foreach (int value in intersection)
            {
                Console.WriteLine(value);
            }

            Console.ReadLine();*/

            // Example dictionaries
            List<Dictionary<int, string>> list1 = new List<Dictionary<int, string>>
            {
                new Dictionary<int, string> { { 1, "a" }, { 2, "b" } },
                new Dictionary<int, string> { { 3, "c" } }
            };

            List<Dictionary<int, string>> list2 = new List<Dictionary<int, string>>
            {
                new Dictionary<int, string> { { 1, "a" }, { 4, "d" } },
                new Dictionary<int, string> { { 2, "b" }, { 3, "e" } }
            };

            // Find the intersection
            var intersection = FindIntersection(list1, list2);

            // Print the intersection
            foreach (var dict in intersection)
            {
                foreach (var kvp in dict)
                {
                    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
                }
            }

            Console.ReadLine();
        }

        public static List<Dictionary<int, string>> FindIntersection(
            List<Dictionary<int, string>> list1,
            List<Dictionary<int, string>> list2)
        {
            var result = new List<Dictionary<int, string>>();

            foreach (var dict1 in list1)
            {
                foreach (var dict2 in list2)
                {
                    var intersectionDict = dict1.Where(kvp => dict2.Contains(kvp))
                                                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                    if (intersectionDict.Any())
                    {
                        result.Add(intersectionDict);
                    }
                }
            }

            return result;
        }
    }
}
