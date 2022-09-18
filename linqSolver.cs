using linq_playground;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

class linqSolver : oldSchoolSolver {  // inhertits solver!!!
  private Numbers num;
  public linqSolver(int size, int start, int stop, bool output) 
            : base(size, start, stop, output) {
    num = new Numbers(size, start, stop);
    
    task1(true);
  }
  // print every numbers
  public override void task1(bool output) {
    IEnumerable<int> elementsQuery =
      from elements in num.rndArr
      select elements;
    foreach (int e in elementsQuery)
      Console.WriteLine(e);
  }

}
