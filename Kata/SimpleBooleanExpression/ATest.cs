using NFluent;

namespace SimpleBooleanExpression;

public class ATest
{
    [Fact(DisplayName = "Returns true if i or j equals 1, false otherwise")]
    public void Should_Work_When_Equals()
    {
        var result1 = A.Test(i: 1, j: 5);
        Check.That(result1).IsTrue();

        var result2 = A.Test(i: 8, j: 1);
        Check.That(result2).IsTrue();

        var result3 = A.Test(i: 1, j: 1);
        Check.That(result3).IsTrue();

        var result4 = A.Test(i: 2, j: 3);
        Check.That(result4).IsFalse();

        var result5 = A.Test(i: 5, j: -1);
        Check.That(result5).IsFalse();

        var result6 = A.Test(i: -6, j: 2);
        Check.That(result6).IsFalse();

        var result7 = A.Test(i: -7, j: -4);
        Check.That(result7).IsFalse();
    }

    [Fact(DisplayName = "Returns true if i + j equals 1")]
    public void Should_Work_When_Add()
    {
        var result1 = A.Test(i: -3, j: 4);
        Check.That(result1).IsTrue();

        var result2 = A.Test(i: 8, j: -7);
        Check.That(result2).IsTrue();
    }
}