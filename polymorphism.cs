using System;
 namespace PolymorphismApplication {
   class Write {
     void print (int n) {
       Console.WriteLine("Print: {0}", n);
     }
     void print (double nn) {
       Console.WriteLine("Print: {0}", nn);
     }
     void print (string nnn) {
       Console.WriteLine("Print: {0}", nnn);
     }
     static void Main(string[] args) {
       Write nnnn = new Write();

       //int print
       nnnn.print(123);
       //float print
       nnnn.print(123.456);
       //string print
       nnnn.print("Testing");
       Console.ReadKey();
     }
   }
 }