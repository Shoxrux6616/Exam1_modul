namespace Exam1Modul;

internal class Program
{
    static void Main(string[] args)
    {

        
    }

    /*// 1-misol
    public static bool StartEndTrueFalse(string text)
    {
        if(text.StartsWith("crud") && text.EndsWith("crud"))
        {
            return true;
        }
            return false;
    }*/

    /*// 2-misol
    public static int SumOfEvenElements(List<int> number)
    {
        var total = 0;
        for (int i = 100; i < 1000; i++)
        {
            if (number[i] %2 == 0)
            {
                number[i] += total;
            }
        }
        return total;
    }*/

    /*// 3-misol
    public static bool StartEndSmuleText(List<char> text)
    {
        text.ToString();
        if (text[0] >= 'a' && text[0] <= 'z' && text[text.Count -1] == 'a' && text[text.Count - 1] == 'z')
        {
            return true;
        }
        return false;
    }*/

    /*// 4-misol
    public static string StartEndRemove(string text)
    {
        if (text.Length > 4)
        {
            text.Remove(0, 2);
            text.Remove(text.Length - 2, 2);
        }
        return text;
    }*/
}
