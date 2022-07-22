using System;
class exercicio5 {
  static void Main() {
    int num1 = 1;
    int num2 = 1;
    Console.Write(num1 + " ");
    while (num1 <= 9) {
      Console.Write(num1+num2);
      num2 += num1;
      num1++;
      if (num1 <= 9) Console.Write(" ");
    }
  }
}