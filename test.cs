using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
namespace Pro {
  class Pro {
   public static void Main(string[] args) {
      Console.WriteLine("Hi");
      Fun();
      System.Threading.Thread.Sleep(10000);
    }

    public static void Fun() {
      String[] llista = {"a", "b", "c"};
      Parallel.For(0,llista.Length, (i) => {
        Console.WriteLine(llista[i]);
        System.Threading.Thread.Sleep(10000);
        Console.WriteLine("> " + llista[i] + " = " +  DateTime.Now);
      });
      Console.WriteLine("Final");
    }
  }
}
