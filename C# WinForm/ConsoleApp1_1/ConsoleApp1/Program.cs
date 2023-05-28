//class IntoSample1
//{
//    static void Main()
//    {

//        // Create a data source.
//        string[] words = { "apples", "blueberries", "oranges", "bananas", "apricots" };

//        // Create the query.
//        var wordGroups1 =
//            from w in words
//            group w by w[0] into fruitGroup
//            where fruitGroup.Count() >= 2
//            select new { FirstLetter = fruitGroup.Key, Words = fruitGroup.Count() };

//        // Execute the query. Note that we only iterate over the groups,
//        // not the items in each group
//        foreach (var item in wordGroups1)
//        {
//            Console.WriteLine(" {0} has {1} elements.", item.FirstLetter, item.Words);
//        }

//        // Keep the console window open in debug mode
//        Console.WriteLine("Press any key to exit.");
//        Console.ReadKey();
//    }
//}
///* Output:
//   a has 2 elements.
//   b has 2 elements.
//*/
//class LetSample1
//{
//    static void Main()
//    {
//        string[] strings =
//        {
//            "A penny saved is a penny earned.",
//            "The early bird catches the worm.",
//            "The pen is mightier than the sword."
//        };

//        // Split the sentence into an array of words
//        // and select those whose first letter is a vowel.
//        var earlyBirdQuery =
//            from sentence in strings
//            let words = sentence.Split(' ')
//            from word in words
//            let w = word.ToLower()
//            where w[0] == 'a' || w[0] == 'e'
//                || w[0] == 'i' || w[0] == 'o'
//                || w[0] == 'u'
//            select word;

//        // Execute the query.
//        foreach (var v in earlyBirdQuery)
//        {
//            Console.WriteLine("\"{0}\" starts with a vowel", v);
//        }

//        // Keep the console window open in debug mode.
//        Console.WriteLine("Press any key to exit.");
//        Console.ReadKey();
//    }
//}
///* Output:
//    "A" starts with a vowel
//    "is" starts with a vowel
//    "a" starts with a vowel
//    "earned." starts with a vowel
//    "early" starts with a vowel
//    "is" starts with a vowel
//*/

using System;
using System.Drawing;

public class Example
{
    public static void Main()
    {
        // Create an array of Point structures.
        Point[] points = { new Point(100, 200),
                         new Point(150, 250), new Point(250, 375),
                         new Point(275, 395), new Point(295, 450) };

        // Find the first Point structure for which X times Y
        // is greater than 100000.
        Point first = Array.Find(points, x => x.X * x.Y > 100000);

        // Display the first structure found.
        Console.WriteLine("Found: X = {0}, Y = {1}", first.X, first.Y);
    }
}
// The example displays the following output:
//        Found: X = 275, Y = 395