using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MoveTowardsZero;

public class A
{
    public static int ClosestToZero(int[] ints)
    {
        if (ints == null || ints.Length == 0)
        {
            return 0;
        }
        int min = ints[0];

        for (int i = 1; i < ints.Length; i++)
        {
            var x = int.MaxValue;
            if (ints[i] != int.MinValue)
            {
                x = Math.Abs(ints[i]);
            }
            if (min == int.MinValue || x <= Math.Abs(min))
            {
                if (ints[i] != int.MinValue)
                {
                    if ((ints[i] + min) == 0)
                    {
                        min = Math.Abs(ints[i]);
                    }
                    else
                    {
                        min = ints[i];
                    }
                }
                else
                {
                    min = int.MinValue;
                }
            }
        }
        return min;
    }

    public static int findSmallestInterval(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return 0;
        }
        int ans = int.MaxValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                if (j != i)
                {
                    int interval = Math.Abs(numbers[i] - numbers[j]);
                    if (ans > interval)
                    {
                        ans = interval;
                    }
                }
            }
        }
        return ans;
    }
}
