using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace linq_playground {
  class Numbers {
    public int[] rndArr { get; }  // private by default?
    public Numbers(int size, int start, int stop) {
      Random rnd = new Random();
      rndArr = Enumerable.Repeat(0, size)
                 .Select(r => rnd.Next(start, stop)).ToArray();
    }
    public void write() {
      rndArr.ToList().ForEach(
            x => Console.WriteLine($"{x}")
        );
    }
  }

  class oldSchoolSolve {
    private Numbers num;
    private int size;
    private bool output;
    public oldSchoolSolve(int size, int start, int stop, bool output) {
      this.size = size;
      this.output = output;
      num = new Numbers(size, start, stop);

      task1(output);
      task2(output);
    }

    // print every numbers
    private void task1(bool output) {
      for (int i = 0; i < num.rndArr.Count(); i++) {
        Console.WriteLine(output ?
          $"{num.rndArr.ElementAt(i)}" : ""
        );
      }
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
  }
  class Program {
    static void Main(string[] args) {
      //oldSchoolSolve s1 = new oldSchoolSolve(10, true);
      Numbers n1 = new Numbers(5, 0, 100);
      n1.write();
    }
  }
}