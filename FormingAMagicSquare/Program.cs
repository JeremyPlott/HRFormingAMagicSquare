using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace FormingAMagicSquare {
    class Program {
        static void Main(string[] args) {

            int[][] s = new int[3][];
            int[] arr1 = { 5, 3, 4 };
            int[] arr2 = { 1, 5, 8 };
            int[] arr3 = { 6, 4, 2 };
            s[0] = arr1;
            s[1] = arr2;
            s[2] = arr3;

            // total sum, closest to nearest division of 9. imagine all 9s, all 8s, etc.
            // or maybe approach by finding the difference between rows/colums/diags

            var total = arr1.Sum() + arr2.Sum() + arr3.Sum();
            var r1s = arr1.Sum();
            var r2s = arr2.Sum();
            var r3s = arr3.Sum();
            var c1s = arr1[0] + arr2[0] + arr3[0];
            var c2s = arr1[1] + arr2[1] + arr3[1];
            var c3s = arr1[2] + arr2[2] + arr3[2];
            var pdi = arr1[2] + arr2[1] + arr3[0];
            var ndi = arr1[0] + arr2[1] + arr3[2];

            List<int> ints = new List<int>();
            ints.Add(r1s); ints.Add(r2s); ints.Add(r3s);
            ints.Add(c1s); ints.Add(c2s); ints.Add(c3s);
            ints.Add(pdi); ints.Add(ndi);

            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach(var i in ints) {
                if(!dict.ContainsKey(i)) {
                    dict.Add(i, 1);
                } else {
                    dict[i]++;
                }                
            }

            foreach(var e in dict) {
                Console.WriteLine(e);
            }
            var highestVal = dict.Values.Max();
            var highestKey = dict.OrderByDescending(e => e.Value).First().Key;

            Console.WriteLine(total);

        }
    }
}
