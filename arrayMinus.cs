
using System;
class HelloWorld {
  static void Main() {

    int[] A = new int[10];
    int[] B = new int[9];

    for (int i = 0; i < A.Length; i++) {
      Console.WriteLine("Enter a number for A: ");
      A[i] = Convert.ToInt32(Console.ReadLine());
    }


    for (int i = 0; i < B.Length; i++) {
        B[i] = A[i]-A[i+1];
    }

    for (int i = 0; i < B.Length; i++) {
      Console.WriteLine(B[i]);
    }
  }
}
