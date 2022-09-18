using linq_playground;
using System;
using System.Diagnostics;
using System.Drawing;

// creating this abstract class was completely pointless, idk why I did this
// at least I revised the basic paradigmas of oop or idk :(
abstract class Solver
{
  private int size, start, stop;
  private bool output;
  private Stopwatch sw = new Stopwatch();
  public Solver(int size, int start, int stop, bool output) {
    this.size = size;
    this.start = start;
    this.stop = stop;
    this.output = output;
  }
  public abstract void task1(bool output);
  public abstract void task2(bool output);
  public abstract void task3(bool output);
  public abstract void task4(bool output);
  public abstract void task5(bool output);
  public abstract void task6(bool output);

  public void solveAll() {


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
  
}


