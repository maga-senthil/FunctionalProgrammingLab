using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{ 
    class LinqExample
    {
        string value ="10,20,30,40";

        string str = "greatJobwhat";
        public void CalculateAverage()
        {
            int i;
            var a = value.Split(new[] { ',' }).Select(s => int.TryParse(s, out i) ? i : 0).ToArray();

            double average = a.Average(mark => mark);
            Console.WriteLine(average);

        }

        public void AlphabeticallyCounted()
        { 
            string sortString = String.Concat(str.ToUpper().OrderBy(c => c));

            var counts = sortString.GroupBy(c => c).Select(g => new { Char = g.Key, Count = g.Count() });

            foreach (var c in counts)
            {
                Console.Write("{0}{1}", c.Char, c.Count);
            }

        }
    }
}
