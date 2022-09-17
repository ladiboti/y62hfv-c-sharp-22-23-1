using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_playground {
  class oldSchoolSolver {
    private Numbers num;
    private int size;
    private bool output;

    private Stopwatch sw = new Stopwatch();

    public oldSchoolSolver(int size, int start, int stop, bool output) {
      this.size = size;
      this.output = output;
      num = new Numbers(size, start, stop);

      sw.Start();

      task1(false);    // not stylish :(
      task2(output);
      task3(output);
      task4(output);
      task5(output);
      task6(output);

      sw.Stop();
      Console.WriteLine(sw.Elapsed);
    }

    // print every numbers
    private void task1(bool output) {
      for (int i = 0; i < num.rndArr.Count(); i++) {
        Console.Write(output ?
          $"{num.rndArr.ElementAt(i)} " : ""
        );
      }
      Console.WriteLine("\n");
    }
    // number of even numbers (páros!!!!)
    private void task2(bool output) {
      int count = 0;
      for (int i = 0; i < num.rndArr.Count(); i++) {
        if (num.rndArr.ElementAt(i) % 2 == 0) {
          count++;
        }
      }
      Console.WriteLine(output ?
        $"the number of odd elements: {count}" : ""
      );
    }

    // count of numbers that can be both divided by 5 and 3
    private void task3(bool output) {
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
    private void task4(bool output) {
      int sum = 0;
      for (int i = 0; i < num.rndArr.Count(); i++)
        sum += num.rndArr.ElementAt(i);

      Console.WriteLine(output ?
       $"the sum of the elements: {sum}" : ""
     );
    }

    // the average of the elements
    private void task5(bool output) {
      int sum = 0;
      for (int i = 0; i < num.rndArr.Count(); i++)
        sum += num.rndArr.ElementAt(i);

      Console.WriteLine(output ?
       $"the average of the elements: {(double)sum / (double)num.rndArr.Count()}" : ""
     );
    }

    // maximum of the elements
    private void task6(bool output) {
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
