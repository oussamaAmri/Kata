static internal bool Check(string str)
{
    if (string.IsNullOrEmpty(str))
    {
        return true;
    }

    var stack = new Stack<char>();

    foreach (var s in str)
    {
        if (s == '(' || s == '[')
        {
            stack.Push(s);
        }
        else
        {
            if (stack.Count == 0)
            {
                return false;
            }
            else
            {
                var result = stack.Pop();

                if (result == '(' && s != ')')
                {
                    return false;
                }

                if (result == '[' && s != ']')
                {
                    return false;
                }
            }
        }
    }

    return stack.Count == 0;
}

internal static int LuckyMoney(int money, int giftees)
{
    if (giftees * 8 <= money)
    {
        return giftees;
    }

    var perfectGift = money / 8;

    while (perfectGift > 0)
    {
        if (perfectGift < 1)
        {
            return 0;
        }

        var remainingGiftees = giftees - perfectGift;
        var remainingMoney = money - perfectGift * 8;

        if (remainingMoney == 4 && remainingGiftees == 1 || remainingMoney < remainingGiftees)
        {
            perfectGift -= 1;
        }
        else
        {
            break;
        }
    }

    return perfectGift;
}