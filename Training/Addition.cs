using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Addition
    {
        static int DoConvert(int[] arr)
        {
            var finalScore = int.Parse(arr
            .Select(x => x.ToString())
            .Aggregate((prev, next) => prev + next));
            return finalScore;
        }
        public static int DoAddition(int ogN)
        {
            if (ogN == 0) return 0;
            var arrayC = ogN.ToString().ToArray();
            var array = Array.ConvertAll(arrayC, i => (int)Char.GetNumericValue(i));
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0} = {1}", i, array[i]);
                array[i] += array[i];
            }
            return DoConvert(array);
        }
    }
}
