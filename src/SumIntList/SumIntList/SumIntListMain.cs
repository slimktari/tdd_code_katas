using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumIntList
{
    public static class SumIntListMain
    {
        public static int [] GetArray(int [] elements, int target)
        {
            var result = new List<int>();

            for(int intialCounter = 0; intialCounter < elements.Length; intialCounter++)
            {
                if (elements[intialCounter] == target)
                {
                    result = new List<int>() { intialCounter };
                    break;
                }
                else
                {
                    for (int counter = intialCounter + 1; counter < elements.Length; counter++)
                    {
                        if(elements[intialCounter] + elements[counter] == target)
                        {
                            result.Add(intialCounter);
                            result.Add(counter);
                        }
                    }
                }
            }
            
            return result.ToArray();
        }
    }
}
