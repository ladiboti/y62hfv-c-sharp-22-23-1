using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace linq_playground {
  class Program {
    static void Main(string[] args) {
      OldSchoolSolver o1 = new OldSchoolSolver(500000, 0, 100, true);
      LinqSolver      l1 = new LinqSolver(500000, 0, 100, true);
    }
  }
}