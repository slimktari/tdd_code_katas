using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumIntList
{
    public static class SumIntListMain
    {
        //public static int [] GetArray(int [] elements, int target)
        //{
        //    var result = new List<int>();

        //    for(int intialCounter = 0; intialCounter < elements.Length; intialCounter++)
        //    {
        //        if (elements[intialCounter] == target)
        //        {
        //            result = new List<int>() { intialCounter };
        //            break;
        //        }
        //        else
        //        {
        //            int sum = 0;
        //            for (int counter = intialCounter + 1; counter < elements.Length; counter++)
        //            {
        //                if(elements[intialCounter] + elements[counter] == target)
        //                {
        //                    result.Add(intialCounter);
        //                    result.Add(counter);
        //                }
        //            }
        //        }
        //    }
        //    return result.ToArray();
        //}

        public static int[] GetArray(int[] elements, int target)
        {
            var result = new List<int>();

            int indexOf = Array.IndexOf(elements, target);
            if (indexOf > 0) return new[] { indexOf };
            int[] filtredElements = elements.Where(e => e < target).ToArray();

            for (int intialCounter = 2; intialCounter <= filtredElements.Length; intialCounter++)
            {
                IEnumerable<IEnumerable<int>> combinations = filtredElements.DifferentCombinations(intialCounter);
                foreach(IEnumerable<int> combination in combinations)
                {
                    if (combination.Sum() == target)
                    {
                        foreach(int element in combination)
                        {
                            result.Add(Array.IndexOf(elements.ToArray(), element));
                        }
                    }
                }
            }

            return result.ToArray();
        }


        public static IEnumerable<IEnumerable<T>> DifferentCombinations<T>(this IEnumerable<T> elements, int k)
        {
            return k == 0 ? new[] { new T[0] } :
              elements.SelectMany((e, i) =>
                elements.Skip(i + 1).DifferentCombinations(k - 1).Select(c => (new[] { e }).Concat(c)));
        }
    }
}
