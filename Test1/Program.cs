// See https://aka.ms/new-console-template for more information

using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
public class wiki
{
    public int _wikiNumber;
    private string wikiName;
    private int wikiDateUpdated;
    public int wikiNumber { get; set;}
}
public class Program
{
    public static void Main()
    {
        Random rnd = new Random();
        wiki objWiki = new wiki();
        List<int> alreadyDisplayed = new List<int>();
        for (int i = 0; i < 5; i++)
        {
            objWiki._wikiNumber = rnd.Next(6);
            if (alreadyDisplayed.Contains(objWiki._wikiNumber))
                --i;
            else
                alreadyDisplayed.Add(objWiki._wikiNumber);
        }
        Console.WriteLine(objWiki._wikiNumber);
    }
}

