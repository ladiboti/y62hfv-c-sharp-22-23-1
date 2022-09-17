using System;

namespace lesson1 {
  class Tester {
    public static int counter = 0;
    public Tester() {
      counter++;
      Console.WriteLine(counter);
    }

    ~Tester() {
      counter = 0;
    }
  }
  class Program {
    static void Main(string[] args) {
      while (true) {
        Tester t = new Tester();
        if (Tester.counter == 0)
          break;
      }
    }
  }
}