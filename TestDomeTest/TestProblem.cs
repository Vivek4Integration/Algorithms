using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDomeTest
{

    public class TestProblem
    {
        public static Tuple<double, double> Areas(double r, double a)
        {
          return  new Tuple<double, double>(AreaOfSegment(r, a), AreaOfCircle(r));
        }

        static double AreaOfSegment(double radius,
            double angle)
        {
            
            double area_of_sector = Math.PI *
                                   (radius * radius) * (angle / 360);

            
            double area_of_triangle =
                (float)1 / 2 * (radius * radius) *
                (float)Math.Sin((angle * Math.PI) / 180);

            return area_of_sector - area_of_triangle;
        }

        static double AreaOfCircle(double radius
            )
        {
            
            double areadOfCircle = Math.PI *
                                    (radius * radius) ;

          
            

            return areadOfCircle;
        }
    }
}
