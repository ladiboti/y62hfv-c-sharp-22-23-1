using linq_playground;
using System;
using System.Diagnostics;
using System.Drawing;

// creating this abstract class was completely pointless, idk why I did this
// at least I revised the basic paradigmas of oop or idk :(
abstract class Solver
{
  private long size, start, stop;
  private bool output;
  private Stopwatch sw = new Stopwatch();
  public Solver(int size, int start, int stop, bool output) {
    this.size = size;
    this.start = start;
    this.stop = stop;
    this.output = output;
  }
  public abstract void printElements(bool output);
  public abstract void evenCounter(bool output);
  public abstract void divisibleCounter(bool output);
  public abstract void sumOfElements(bool output);
  public abstract void averqageOfElements(bool output);
  public abstract void maxOfElements(bool output);

  public void solveAll() {
    sw.Start();

    printElements(false);    // not stylish :(
    evenCounter(output);
    divisibleCounter(output);
    sumOfElements(output);
    averqageOfElements(output);
    maxOfElements(output);

    sw.Stop();
    Console.WriteLine(sw.Elapsed);
  }
  
}


