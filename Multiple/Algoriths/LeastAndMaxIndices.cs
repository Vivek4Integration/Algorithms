using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Algoriths
{

    public class LeastAndMaxIndices
    {
        public List<Int32> NumberArray = new List<int>();

        public int FindRange(int value, int low, int high, bool IsFirst)
        {
            if (high < low)
                return -1;
            

            var midpoint = (low + high) / 2;

            if (IsFirst)
            {
                if ((midpoint == 0 || value > NumberArray[midpoint-1]) && NumberArray[midpoint] == value)
                    return midpoint;
                if (value > NumberArray[midpoint])
                    return FindRange(value, midpoint + 1, high, IsFirst);
                else
                    return FindRange(value, low, midpoint - 1, IsFirst);
                
            }
            else
            {
                if ((midpoint == NumberArray.Count - 1 || value < NumberArray[midpoint + 1]) &&
                    NumberArray[midpoint] == value)
                    return midpoint;
                else if (value < NumberArray[midpoint])
                    return FindRange(value, low, midpoint - 1, IsFirst);
                else
                    return FindRange(value, midpoint + 1, high, IsFirst);
            }


            return -1;




        }


        public int FindRange_Me(int value, int low, int high, bool IsFirst)
        {
            if (low > high)
                return -1;
            var midpoint = (low + high) / 2;

            if (IsFirst)
            {
                if ((midpoint == 0 || value > NumberArray[midpoint - 1]) && value == NumberArray[midpoint])
                {
                    return midpoint;
                }

                if (value>NumberArray[midpoint])
                {
                    return FindRange_Me(value, midpoint + 1, high, IsFirst);
                }
                else
                {
                    return FindRange_Me(value, low, midpoint - 1, IsFirst);
                }
            }
            else
            {
                if ((midpoint == NumberArray.Count-1 || value < NumberArray[midpoint + 1]) && value == NumberArray[midpoint])
                {
                    return midpoint;
                }

                if (value < NumberArray[midpoint])
                {
                    return FindRange_Me(value, low,midpoint-1, IsFirst);
                }
                else
                {
                    return FindRange_Me(value, midpoint+1, high, IsFirst);
                }
            }

            return -1;
        }
    }
}

