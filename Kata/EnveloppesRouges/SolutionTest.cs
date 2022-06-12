using NFluent;

namespace EnveloppesRouges;

public class SolutionTest
{
    [Fact(DisplayName = "Exemples simples")]
    public void Should_Share()
    {
        var result1 = Solution.LuckyMoney(money: 12, giftees: 2);
        Check.That(result1).IsEqualTo(0);
        
        var result2 = Solution.LuckyMoney(money: 24, giftees: 4);
        Check.That(result2).IsEqualTo(2);
        
        var result3 = Solution.LuckyMoney(money: 7, giftees: 2);
        Check.That(result3).IsEqualTo(0);
    }

    [Fact(DisplayName = "Pas de budget")]
    public void Should_Share_When_No_Money()
    {
        var result = Solution.LuckyMoney(money: 0, giftees: 3);

        Check.That(result).IsEqualTo(0);
    }

    [Fact(DisplayName = "Budget parfait")]
    public void Should_Share_When_Perfect_Money()
    {
        var result = Solution.LuckyMoney(money: 24, giftees: 3);

        Check.That(result).IsEqualTo(3);
    }

    [Fact(DisplayName = "Pas de don à 4")]
    public void Should_Share_When_Possibly_Gift_4()
    {
        var result = Solution.LuckyMoney(money: 20, giftees: 3);

        Check.That(result).IsEqualTo(1);
    }

    [Fact(DisplayName = "Pas de don à 0")]
    public void Should_Share_When_Possibly_Gift_0()
    {
        var result = Solution.LuckyMoney(money: 8, giftees: 2);

        Check.That(result).IsEqualTo(0);
    }

    [Fact(DisplayName = "Montants importants")]
    public void Should_Share_When_Big_Money()
    {
        var result = Solution.LuckyMoney(money: 99, giftees: 7);

        Check.That(result).IsEqualTo(7);
    }
}