// See https://aka.ms/new-console-template for more information

using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class wiki
{
    public int _wikiNumber;
    private string wikiName;
    private int wikiDateUpdated;

    public int wikiNumber
    {
        get
        {
            return _wikiNumber;
        }
    }
    
}


/* ToDo:
    For loop to generate 5 different wikis every time the program is run
        **probably run with a small maxValue of let's say 10 to verify everything works properly before
        **running with the 200+ total list
    Make a List of wikiNumber that has already displayed
    Condition the for loop to i-- if there is a number that has been displayed already
    Extra Credit: Find something to do with the other variables
    */

public class Program
{
    public static void Main()
    {
        Random rnd = new Random();
        wiki objWiki = new wiki();
        List<int> alreadyDisplayed = new List<int>();
        
        Console.WriteLine("Test " + objWiki._wikiNumber);
        int i = 0;
        while(i<3)
        {
            objWiki._wikiNumber = rnd.Next(6);
            if (alreadyDisplayed.Contains(objWiki._wikiNumber))
            {
                Console.WriteLine("if the wiki number has already been displayed: " + objWiki._wikiNumber);
                i=0;
                Console.WriteLine("value of i in this if: "+ i);
                Console.WriteLine("");
            }
            else
            {
                alreadyDisplayed.Add(objWiki._wikiNumber);
                i++;
                Console.WriteLine("value of i if the number has not already been displayed "+ i);
                Console.WriteLine("");
                //Console.WriteLine("What has been added to already displayed " + objWiki._wikiNumber);
            }
            Console.WriteLine("wikis already displayed after the logic "+ alreadyDisplayed[0]);
        }
        
            
    }


    void OriginalCodeTest()
    {
        Random rnd = new Random();
        int num = rnd.Next(199);
        for(int i = 0; i<5; i++)
            Console.WriteLine(rnd.Next(0,199));
        List<wiki> list = new List<wiki>();
    }
    
}

