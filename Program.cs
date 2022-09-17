using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            x => Console.Write($"{x} ")
        );
      Console.WriteLine();
    }
  }

  class Program {
    static void Main(string[] args) {
      //oldSchoolSolve s1 = new oldSchoolSolve(10, true);
      oldSchoolSolver o1 = new oldSchoolSolver(5000000, 0, 100, true);
    }
  }
}