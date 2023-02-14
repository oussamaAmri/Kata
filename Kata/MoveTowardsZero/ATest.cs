using NFluent;

namespace MoveTowardsZero;

public class ATest
{
    [Fact(DisplayName = "The result is correct with a simple data set [7, 5, 9, 1, 4]")]
    public void Should_Find_Closest_To_Zero()
    {
        var ints = new[] { 7, 5, 9, 1, 4 };

        var result = A.ClosestToZero(ints);

        Check.That(result).IsEqualTo(1);
    }

    [Fact(DisplayName = "The solution works with 2147483647 or -2147483647")]
    public void Should_Find_Closest_To_Zero_When_Min_And_Max_Integers()
    {
        var ints1 = new[] { 7, int.MinValue, 9, 1, 4 };
        var result1 = A.ClosestToZero(ints1);
        Check.That(result1).IsEqualTo(1);

        var ints2 = new[] { 7, 5, 9, int.MaxValue, 4 };
        var result2 = A.ClosestToZero(ints2);
        Check.That(result2).IsEqualTo(4);

        var ints3 = new[] { int.MinValue, 1, 9, int.MaxValue, 5 };
        var result3 = A.ClosestToZero(ints3);
        Check.That(result3).IsEqualTo(1);

        var ints4 = new[] { int.MinValue, int.MaxValue };
        var result4 = A.ClosestToZero(ints4);
        Check.That(result4).IsEqualTo(int.MaxValue);
        
        var ints5 = new[] { int.MinValue, int.MinValue };
        var result5 = A.ClosestToZero(ints5);
        Check.That(result5).IsEqualTo(int.MinValue);


    }
    [Fact(DisplayName = "The solution works with negative numbers")]
    public void Should_Find_Closest_To_Zero_When_Min_And_Min_Integers()
    {
        var ints5 = new[] { -5, -5 };
        var result5 = A.ClosestToZero(ints5);
        Check.That(result5).IsEqualTo(-5);
    }



    [Fact(DisplayName = "The solution works when the array contains only negative integers")]
    public void Should_Find_Closest_To_Zero_When_Only_Negative_Intergers()
    {
        var ints = new[] { -7, -3, -9, -4 };

        var result = A.ClosestToZero(ints);

        Check.That(result).IsEqualTo(-3);
    }

    [Fact(DisplayName = "When two integers are as close to 0, then the positive wins")]
    public void Should_Find_Closest_To_Zero_When_2_Integers_Are_Close_To_0()
    {
        var ints = new[] { 7, -3, 9, 3, 4 };

        var result = A.ClosestToZero(ints);

        Check.That(result).IsEqualTo(3);
    }

    [Fact(DisplayName = "The solution works when the array contains only two equal negative integers")]
    public void Should_Find_Closest_To_Zero_When_Same_2_Negative_Integers()
    {
        var ints = new[] { 6, -2, 3, -2, 9 };

        var result = A.ClosestToZero(ints);

        Check.That(result).IsEqualTo(-2);
    }

    [Fact(DisplayName = "The solution works with an empty array")]
    public void Should_Find_Closest_To_Zero_When_Empty_Array()
    {
        var result = A.ClosestToZero(Array.Empty<int>());

        Check.That(result).IsEqualTo(0);
    }

    [Fact(DisplayName = "The solution works with a null array")]
    public void Should_Find_Closest_To_Zero_When_Null_Array()
    {
        var result = A.ClosestToZero(null!);

        Check.That(result).IsEqualTo(0);
    }
    [Fact(DisplayName = "FindSmallinterval")]
    public void Should_Find_Small_interval()
    {
        var ints = new[] { 6, -1, 3, -2, 9 };

        var result = A.findSmallestInterval(ints);

        Check.That(result).IsEqualTo(1);
    }
}
