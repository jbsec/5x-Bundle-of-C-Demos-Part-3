using System;

namespace ArrayApplication {
  class MyArray {
    static void Main(string[] args) {
      int [] n = new int[10]; // n arrya is 10 allocated spaces
      int i, j;

      //init array elements of n
      for ( i = 0; i < 10; i++ ) {
        n[ i ] = i + 100;
      }

      //output array element
      for (j =0; j < 10; j++) {
        Console.WriteLine("Element[{0}] = {1}", j, n[j]);
      }
      Console.ReadKey();
    }
  }
}