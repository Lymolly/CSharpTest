using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    public class WorkDayCalculator : IWorkDayCalculator
    {
        public DateTime Calculate(DateTime startDate, int dayCount, WeekEnd[] weekEnds)
        {
            DateTime endDate = default;
            if (weekEnds != null)
            {
                List<DateTime> list = new List<DateTime>();
                List<DateTime> weeks = new List<DateTime>();
                list.Add(startDate);

                //Adding days without weekends
                for (int i = 1; i < dayCount; i++)
                {
                    list.Add(startDate.AddDays(i));
                }
                //Adding weekends
                for (int i = 0; i < weekEnds.Length; i++)
                {
                    for (int j = 0; i < weekEnds[i].EndDate.Day - weekEnds[i].StartDate.Day; j++)
                    {
                        weeks.Add(weekEnds[i].StartDate.AddDays(j));
                        var temp = weekEnds[i].StartDate.AddDays(j);
                        if (temp == weekEnds[i].EndDate)
                        {
                            break;
                        }
                    }
                }
                ///Insert weekends into day's list and get full collection with dates with weekends
                var count = 0;
                for (int i = 0; i < list.Count+weeks.Count; i++)
                {
                    if (list[i].Date == weeks[0].Date)
                    {
                        foreach (var item in weeks)
                        {
                            list.Insert(count,item);
                        }
                        break;
                    }
                    count++;
                }
                //Calculating end date
                endDate = list[0].AddDays(list.Count() - 1);
                return endDate;
            }
            //If array of weekends is null - return calculated end date
            else
            {
                endDate = startDate.AddDays(dayCount - 1);
                return endDate;
            }
        }
    }
}
