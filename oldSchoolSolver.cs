using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_playground {
  class OldSchoolSolver : Solver {
    private Numbers num;

    public OldSchoolSolver(int size, int start, int stop, bool output)
            : base(size, start, stop, output) {

      num = new Numbers(size, start, stop);
      base.solveAll();
    }

    // print every numbers
    public override void printElements(bool output) {
      for (int i = 0; i < num.rndArr.Count(); i++) {
        Console.Write(output ?
          $"{num.rndArr.ElementAt(i)} " : ""
        );
      }
      Console.WriteLine("\n");
    }
    // number of even numbers (páros!!!!)
    public override void evenCounter(bool output) {
      int count = 0;
      for (int i = 0; i < num.rndArr.Count(); i++) {
        if (num.rndArr.ElementAt(i) % 2 == 0) {
          count++;
        }
      }
      Console.WriteLine(output ?
        $"the number of even elements: {count}" : ""
      );
    }

    // count of numbers that can be both divided by 5 and 3
    public override void divisibleCounter(bool output) {
      int count = 0;
      for (int i = 0; i < num.rndArr.Count(); i++) {
        if (num.rndArr.ElementAt(i) % 3 == 0 && num.rndArr.ElementAt(i) % 5 == 0) {
          count++;
        }
      }
      Console.WriteLine(output ?
       $"the count of numbers that can be both divided by 5 and 3: {count}" : ""
     );
    }

    // the sum of the elements
    public override void sumOfElements(bool output) {
      int sum = 0;
      for (int i = 0; i < num.rndArr.Count(); i++)
        sum += num.rndArr.ElementAt(i);

      Console.WriteLine(output ?
       $"the sum of the elements: {sum}" : ""
      );
    }

    // the average of the elements
    public override void averqageOfElements(bool output) {
      int sum = 0;
      for (int i = 0; i < num.rndArr.Count(); i++)
        sum += num.rndArr.ElementAt(i);

      Console.WriteLine(output ?
       $"the average of the elements: {(double)sum / (double)num.rndArr.Count()}" : ""
     );
    }

    // maximum of the elements
    public override void maxOfElements(bool output) {
      int max = 0;
      for (int i = 0; i < num.rndArr.Count(); i++)
        if (num.rndArr.ElementAt(i) > max)
          max = num.rndArr.ElementAt(i);

      Console.WriteLine(output ?
        $"the maximum of the elements: {max}" : ""
     );
    }
  }
}
