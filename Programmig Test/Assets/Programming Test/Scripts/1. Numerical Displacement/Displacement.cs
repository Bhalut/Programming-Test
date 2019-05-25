using UnityEngine;

public class Displacement
{
    public string DisplacementPosition(string numbers, int position)
    {
        char[] c = numbers.ToCharArray();
        char[] numbersChar = new char[numbers.Length];
        var x = 0;
        
        for (int i = 0; i < c.Length; i++)
        {
            if (i + position + 1 >= c.Length)
            {
                numbersChar[i] = c[x];
                x++;
            }
            else
            {
                numbersChar[i] = c[i + position + 1];
            }
        }
        string result = new string(numbersChar);
        
        return $"{result}";
    }
}
