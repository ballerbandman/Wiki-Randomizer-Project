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
    


/* ToDo:
    100000 Points: Comment wtf this shit does, in both main and dev branches
    Find a way to add the values from the string list into the int list
    Extra Credit: Find something to do with the other variables
    */

public class Program
{
    public static void Main()
    {
       //makes a list for storing all the data
        List<string> fileContents = new List<string>();
        
        //tells the computer where the file is, and creates a non list to read all that data
        string file = @"C:\Users\ststaffo\RiderProjects\Test1\TextTest1.txt";
        string existingFileContents = File.ReadAllText(file);
        
        //adds all values from the file into the list
        fileContents.Add(existingFileContents);
        //testing to ensure it worked properly, for some reason if we don't use string.Join(), we get the name of the list not the actual contents so this is our workaround
        Console.WriteLine((string.Join("",fileContents)));

        //setting up the randomizer
        Random rnd = new Random();
        wiki objWiki = new wiki();
        //List that stores the values, needs to be an int because we do math with those numbers
        List<int> alreadyDisplayed = new List<int>();
        for (int i = 0; i < 5; i++)
        {
            objWiki._wikiNumber = rnd.Next(6);
            if (alreadyDisplayed.Contains(objWiki._wikiNumber))
                --i;
            else
            {
                alreadyDisplayed.Add(objWiki._wikiNumber);
            }

            
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

