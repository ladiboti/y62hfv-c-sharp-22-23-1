using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace zh1
{
  internal class lesson6
  {
    static void Main(string[] args)
    {
      List<string> sList = new List<string>();
      List<int> iList = new List<int>();

      using (var reader =
        new StreamReader(@"mindenfele.csv"))
      {
        while (!reader.EndOfStream)
        {
          var line = reader.ReadLine();
          int numval;

          if (int.TryParse(line, out numval))
          {
            iList.Add(numval);
          }
          else
          {
            sList.Add(line);
          }
        }
      }
      //iList.ForEach(x => Console.WriteLine(x));
      //sList.ForEach(x => Console.WriteLine(x));

      //3
      Console.WriteLine("numbers greater than 20:");

      var graterThan20 =
        from num in iList
        where num > 20
        select num;

      foreach (var num in graterThan20)
        Console.WriteLine(num);

      //4
      Console.WriteLine("\noccurencies of each number the list:");
      var frequencies =
        from x in iList
        group x by x into num
        select num;

      foreach (var num in frequencies)
        Console.WriteLine(
          $"{num.Key} appears {num.Count()} times"
         );

      //5
      Console.WriteLine("\ndelete words from list starting with the most frequent letter");
      var firstLetterFreq =
        from s in sList
        group s by s[0] into word
        select word;

      //var maxfreq = firstLetterFreq.OrderBy()
      Dictionary<char, int> freq =
          new Dictionary<char, int>();

      foreach (var word in firstLetterFreq)
        freq.Add(word.Key, word.Count());

      var sortedFreq =
        from entry in freq orderby entry.Value descending select entry;


      string commonStart = sortedFreq.First().Key.ToString();
      Console.WriteLine(commonStart);

      sList.ToList().ForEach(x =>
      {
        if (x.StartsWith(commonStart))
          sList.Remove(x);
      });

      sList.ForEach(x => Console.WriteLine(x));

      //6
      Console.WriteLine($"\nNumbers less than the average ({Math.Round(iList.Average(), 3)})");
      var lessThanAverage =
        from num in iList
        where num < iList.Average()
        select num;

      foreach (var num in lessThanAverage)
        Console.WriteLine(num);

      //7
      //átsiklott rajta a szemem, elfelejtettem megcsináni :(((
      sList.ForEach(x =>
      {
        Console.WriteLine(x + ": " + x.Count(x => x == 's'));
      });

      //8
      //TODO

      //9
      Random rnd = new Random();
      int task = rnd.Next(0, 21);
      Console.WriteLine($"\tDEBUG random = {task}");

      int guess = -1;
      Console.WriteLine("guess a random number between 0 and 21");
      while (guess != task)
      {
        Console.Write("your guess: ");
        guess = int.Parse(Console.ReadLine());

        Console.WriteLine(guess == task ? "" : guess > task ? "smaller" : "bigger");
      }
      Console.WriteLine("you won!!!");
      Console.ReadKey();
    }
  }
}
