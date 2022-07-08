using System;
class exercicio5 {
  static void Main() {
    int num1 = 1;
    int num2 = 0;
    int soma;
      while (num1 + num2 <= 46) {
      soma = num1 + num2;
      Console.Write(soma);
      num2 = soma + num1;
      num2++;
      if (soma < 46) Console.Write(" ");
    }
  }
}