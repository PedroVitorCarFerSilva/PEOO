using System;
class exercicio5 {
  static void Main() {
    int num1 = 1;
    int num2 = 0;
    int soma;
    while (num1 <= 30) {
      soma = num1 + num2;
      Console.Write(num1);
      if (num1%3 == 0) {
        Console.Write($" {soma}");
        soma = 0;
      }
      num2 = num1 + (num1-1);
      num1++;
      if (num1 <= 30) Console.Write(" ");
    }
  }
}