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
        static void Main(string[] args)
        {
            List<Dictionary<int, string>> list1 = new List<Dictionary<int, string>>
            {
                new Dictionary<int, string> { { 1, "a" }, { 2, "b" }, { 3, "c" }, { 4, "f" }, { 5, "d"} }
            };

            List<Dictionary<int, string>> list2 = new List<Dictionary<int, string>>
            {
                new Dictionary<int, string> { { 1, "a" }, { 2, "b" }, {3 , "d" }, { 4, "c" }, { 5, "e" } }
            };

            List<Dictionary<int, string>> answers = new List<Dictionary<int, string>>();

            if (list1 != null && list2 != null)
            {
                for(int i  = 0; i < list1.Count; i++)
                {
                    /*if (list1[i].Keys == list2[i].Keys && list1[i].Values == list2[i].Values)
                    {
                        answers.Add(list1[i]);
                        answers.Add(list2[i]);
                    } else if (list1[i].Keys < list2[i].Keys)
                    {

                    }*/
                }
            }
        }
    }
}
