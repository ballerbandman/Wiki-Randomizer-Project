﻿// See https://aka.ms/new-console-template for more information

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
        for (int i = 0; i < 5; i++)
        {
            objWiki._wikiNumber = rnd.Next(6);
            if (alreadyDisplayed.Contains(objWiki._wikiNumber))
            {
                --i;
                Console.WriteLine("Random has already been displayed ");
            }
            else
            {
                alreadyDisplayed.Add(objWiki._wikiNumber);
                //Console.WriteLine("If random is NOT in already dispalyed " + objWiki._wikiNumber);
            }
            Console.WriteLine(objWiki._wikiNumber);
            
        }
        //Console.WriteLine(alreadyDisplayed[4]);
            
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
