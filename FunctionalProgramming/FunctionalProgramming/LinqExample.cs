using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{ 
    class LinqExample
    {
        string value = "90,100,82,89,55";

        string str = "greatJobwhat";
        public void CalculateAverage()
        {
            int i;
            var numberList = value.Split(new[] { ',' }).Select(s => int.TryParse(s, out i) ? i : 0).ToList();

            var maxObject = numberList.OrderBy(item => item).Skip(3);
           
            double average = maxObject.Average();
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
