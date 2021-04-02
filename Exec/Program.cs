using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpTest;

namespace Exec
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 10;
            DateTime startDate = new DateTime(2021, 12, 1);
            WorkDayCalculator wdc = new WorkDayCalculator();
            var res = wdc.Calculate(startDate, count, null);
            Console.WriteLine(res);
            int count1 = 10;
            WeekEnd[] weekends = new WeekEnd[1]
            {
                new WeekEnd(new DateTime(2021, 4, 23), new DateTime(2021, 4, 25))
            };
            DateTime startDate1 = new DateTime(2021, 4, 21);
            WorkDayCalculator wdc1 = new WorkDayCalculator();
            var res1 = wdc.Calculate(startDate1, count1, weekends);
            //Console.WriteLine(res1);
            //List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7};
            //List<int> list = new List<int> {12, 13, 14};
            ////ints[0] = 5;
            //foreach (var item in ints)
            //{
            //    Console.Write(item + " ");
            //}


            //var count = 0;
            //for (int i = 0; i < ints.Count; i++)
            //{
            //    if (ints[i] == 3)
            //    {
            //        var l = Enumerable.Range(list[0], list.Count).ToList();
            //        l.Sort();
            //        foreach (var item in l)
            //        {
            //            ints.Insert(count,item);
            //        }
            //        break;
            //    }
            //    count++;
            //}

            //Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.Red;
            //foreach (var item in ints)
            //{
            //    Console.Write(item + " ");
            //}


            Console.Read();
        }
    }
}
