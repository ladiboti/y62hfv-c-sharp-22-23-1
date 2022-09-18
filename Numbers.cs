using System;
using System.Linq;

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