using NFluent;

namespace LargestWinsFromChaos;

public class AlgorithmTest
{
    [Fact(DisplayName = "It works using simple data sample")]
    public void Should_Find_Largest()
    {
        var numbers = new[] { 5, 2, 4, 6, 1 };

        int result = Algorithm.FindLargest(numbers);

        Check.That(result).IsEqualTo(6);
    }

    [Fact(DisplayName = "Still works when the array contains only int.MinValue")]
    public void Should_Find_Largest_When_Array_Contains_Only_Int_MinValue()
    {
        var numbers = new[] { int.MinValue, int.MinValue, int.MinValue };

        int result = Algorithm.FindLargest(numbers);

        Check.That(result).IsEqualTo(int.MinValue);
    }

    [Fact(DisplayName = "Still works if the largest number is at position 0 in the array")]
    public void Should_Find_Largest_When_Largest_Number_Is_At_Position_0()
    {
        var numbers = new[] { 10, 2, 8, 6 };

        int result = Algorithm.FindLargest(numbers);

        Check.That(result).IsEqualTo(10);
    }

    [Fact(DisplayName = "Still works if the largest number is at the last position in the array")]
    public void Should_Find_Largest_When_Largest_Number_Is_At_Last_Position()
    {
        var numbers = new[] { 4, 3, 5, 9 };

        int result = Algorithm.FindLargest(numbers);

        Check.That(result).IsEqualTo(9);
    }
}