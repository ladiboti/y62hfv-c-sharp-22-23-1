using linq_playground;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

class LinqSolver : Solver {  // inhertits solver!!!
  private Numbers num;
  public LinqSolver(int size, int start, int stop, bool output) 
            : base(size, start, stop, output) {

    num = new Numbers(size, start, stop);
    base.solveAll();
  }
  // print every numbers
  public override void printElements(bool output) {
    if (output)
      num.rndArr.ToList().ForEach(
        e => Console.Write($"{e} ")
      );
  }

  // number of even numbers
  public override void evenCounter(bool output) {
    Console.WriteLine(output ? 
      "\nthe number of even elements: " + 
      num.rndArr
      .Where(e => e % 2 == 0)
      .Count() : ""
    );
  }
  // count of numbers that can be both divided by 5 and 3
  public override void divisibleCounter(bool output) {
    Console.WriteLine(output ? 
     "the count of numbers that can be both divided by 5 and 3: " +
     num.rndArr
     .Where(e => e % 3 == 0 && e % 5 == 0)
     .Count() : ""
   );
  }
  // the sum of the elements
  public override void sumOfElements(bool output) {
    Console.WriteLine(output ?
       $"the sum of the elements: {num.rndArr.ToList().Sum()}" : ""
    );
  }
  // the average of the elements
  public override void averqageOfElements(bool output) {
    Console.WriteLine(output ?
      $"the average of the elements: {num.rndArr.ToList().Average()}" : ""
    );
  }
  // maximum of the elements
  public override void maxOfElements(bool output) {
    Console.WriteLine(output ?
      $"the maximum of the elements: {num.rndArr.ToList().Max()}" : ""
    );
  }


}
