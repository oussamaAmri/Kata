namespace LargestWinsFromChaos;

public class Algorithm
{
    public static int FindLargest(int[] numbers)
    {
        int largest = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > largest)
                largest = numbers[i];
        }
        return largest;
    }
}
