using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Concrete
{
    public static class Extensions
    {
        public static List<int> ShellSort(this List<int> list)
        {
            int i = 0, j = 0, k = 0, temp = 0;

            for (k = list.Count - 1; k > 1;)
            {
                k = (k < 5) ? 1 : ((k * 5 - 1) / 11);
                for (i = k - 1; ++i < list.Count - 1;)
                {
                    temp = list[i];
                    for (j = i; list[j - k] > temp;)
                    {
                        list[j] = list[j - k];
                        if ((j -= k) < k)
                        {
                            break;
                        }
                    }
                    list[j] = temp;
                }
            }

            return list;
        }

        public static List<int> MergeSort(this List<int> list)
        {
            int middle = (list.Count - 1) / 2;
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            List<int> result = new List<int>();

            if (list.Count - 1 <= 1)
            {
                return list;
            }

            for (int i = 0; i < middle; i++)
            {
                left.Add(list[i]);
            }

            for (int i = middle; i < list.Count - 1; i++)
            {
                right.Add(list[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            result = Merge(left, right);

            return result;
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            int x = 0, y = 0;

            while (left.Count - 1 > x && right.Count - 1 > y)
            {
                if (left[x] <= right[y])
                {
                    result.Add(left[x]);
                    x++;
                }
                else
                {
                    result.Add(right[y]);
                    y++;
                }
            }

            if (left.Count - 1 > x)
            {
                while (x < left.Count - 1)
                {
                    result.Add(left[x]);
                    x++;
                }
            }

            if (right.Count - 1 > y)
            {
                while (y < right.Count - 1)
                {
                    result.Add(right[y]);
                    y++;
                }
            }

            return result;
        }
    }
}
