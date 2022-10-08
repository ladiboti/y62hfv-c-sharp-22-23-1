using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson4 {
  internal class Program {
    static void Main(string[] args) {
      int[] n1 = {
                1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14
            };

      var oddQuery =
            from VrNum in n1
            where (VrNum % 2) == 0
            select VrNum;

      // The third part is Query execution.

      Console.Write("\nThe numbers which produce the remainder 0 after divided by 2 are : \n");
      foreach (int VrNum in oddQuery)
      {
        Console.Write("{0} ", VrNum);
      }
      Console.Write("\n\n");

      Console.Write("\nLINQ : Using multiple WHERE clause to find the positive numbers within the list : ");
      Console.Write("\n-----------------------------------------------------------------------------");

      var nQuery =
        from VrNum in n1
        where VrNum > 0
        where VrNum < 12
        select VrNum;

      Console.Write("\nThe numbers within the range of 1 to 11 are : \n");
      foreach (var VrNum in nQuery)
      {
        Console.Write("{0}  ", VrNum);
      }
      Console.Write("\n\n");


      Console.Write("\nLINQ : Find the number and its square of an array which is more than 20 : ");
      Console.Write("\n------------------------------------------------------------------------\n");

      var sqNo = from int Number in n1
                 let SqrNo = Number * Number
                 where SqrNo > 20
                 select new { Number, SqrNo };

      foreach (var a in sqNo)
        Console.WriteLine(a);


      Console.Write("\nLINQ : Display the number and frequency of number from given array : \n");
      Console.Write("---------------------------------------------------------------------\n");

      var n = from x in n1
              group x by x into y
              select y;
      Console.WriteLine("\nThe number and the Frequency are : \n");
      foreach (var arrNo in n)
      {
        Console.WriteLine("Number " + arrNo.Key + " appears " + arrNo.Count() + " times");
      }
      Console.WriteLine("\n");


      string str;

      Console.Write("\nLINQ : Display the characters and frequency of character from giving string : ");
      Console.Write("\n----------------------------------------------------------------------------\n");
      Console.Write("Input the string : ");
      str = Console.ReadLine();
      Console.Write("\n");

      var FreQ = from x in str
                 group x by x into y
                 select y;
      Console.Write("The frequency of the characters are :\n");
      foreach (var ArrEle in FreQ)
      {
        Console.WriteLine("Character " + ArrEle.Key + ": " + ArrEle.Count() + " times");
      }


      var m = from x in n1
              group x by x into y
              select y;
      Console.Write("Number" + "\t" + "Number*Frequency" + "\t" + "Frequency" + "\n");
      Console.Write("------------------------------------------------\n");

      foreach (var arrEle in m)
      {
        Console.WriteLine(arrEle.Key + "\t" + arrEle.Sum() + "\t\t\t" + arrEle.Count());
      }
      Console.WriteLine();


      string chst, chen;
      char ch;
      string[] cities =
      {
         "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
      };

      Console.Write("\nLINQ : Find the string which starts and ends with a specific character : ");
      Console.Write("\n-----------------------------------------------------------------------\n");
      Console.Write("\nThe cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS' \n");

      Console.Write("\nInput starting character for the string : ");
      ch = (char)Console.Read();
      chst = ch.ToString();
      Console.Write("\nInput ending character for the string : ");
      ch = (char)Console.Read();
      chen = ch.ToString();


      var _result = from x in cities
                    where x.StartsWith(chst)
                    where x.EndsWith(chen)
                    select x;
      Console.Write("\n\n");
      foreach (var city in _result)
      {
        Console.Write("The city starting with {0} and ending with {1} is : {2} \n", chst, chen, city);
      }

      Console.ReadLine();


      int i = 0;
      List<int> templist = new List<int>();
      templist.Add(55);
      templist.Add(200);
      templist.Add(740);
      templist.Add(76);
      templist.Add(230);
      templist.Add(482);
      templist.Add(95);

      Console.Write("\nLINQ : Create a list of numbers and display the numbers greater than 80 : ");
      Console.Write("\n-------------------------------------------------------------------------\n");
      Console.WriteLine("\nThe members of the list are : ");
      foreach (var lstnum in templist)
      {
        Console.Write(lstnum + " ");
      }
      List<int> FilterList = templist.FindAll(x => x > 80 ? true : false);
      Console.WriteLine("\n\nThe numbers greater than 80 are : ");
      foreach (var num in FilterList)
      {
        Console.WriteLine(num);
      }
      Console.ReadLine();
    }
  }
}
