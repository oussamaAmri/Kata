namespace StringParser;

public class Answer
{
    static public bool Check(string str)
    {
        if (str == null || str.Length == 0)
        {
            return true;
        }
        Stack<char> pile = new Stack<char>(); 
        foreach (var s in str)
        {
            if (s == ')')
            {
                var isExiste = pile.TryPeek(out char result); // Returns the object at the top of the System.Collections.Generic.Stack`1 without
                                           // removing it.                
                if (isExiste && result == '(')
                {
                        pile.Pop(); // supprimer l'element de la pile 
                }
                else
                {
                    pile.Push(s); //inserer l'element dans la pile 
                }
            }
            else if (s == ']')
            {
                if (pile.TryPeek(out char result) && result == '[')
                {
                    pile.Pop();
                }
                else
                {
                    pile.Push(s);
                }
            }
            else
            {
                pile.Push(s);
            }
        }         
        // Test si c'est vide
        if(pile.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
