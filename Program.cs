using System;
using System.Threading;

namespace linq_playground {
  class Program {
    static void Main(string[] args) {
      OldSchoolSolver o1 = new OldSchoolSolver(5000, 0, 10000, true);
      LinqSolver      l1 = new LinqSolver(5000, 0, 10000, true) ;
    }
  }
}