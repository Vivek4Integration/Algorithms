using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class AverageSalary
    {
        public double Average(int[] salary)
        {
            var max = Int32.MinValue;
            var min = Int32.MaxValue;
            var acc = 0;
            for (int i = 0; i < salary.Length; i++)
            {
                max = Math.Max(salary[i], max);
                min = Math.Min(min, salary[i]);
                acc = salary[i] + acc;
            }
            return ((double)acc - (double)max - (double)min) / (salary.Length - 2);
        }
    }
}
