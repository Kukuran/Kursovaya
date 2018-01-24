using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equalizer
{
    public class Condition
    {
        List<int> cond_arr = new List<int>();
        public Condition(params int[] arr)
        {
            foreach (int param in arr)
            {
                cond_arr.Add(param);
            }
        }
        public bool Check(params int[] arr)
        {
            bool result = false;
            int i = 0;
            int count = 0;
            foreach (int element in cond_arr)
            {
                if (element == arr[i])
                    count++;
                i++;
            }
            if (count == cond_arr.Count)
                result = true;
            return result;
        }
    }
}
