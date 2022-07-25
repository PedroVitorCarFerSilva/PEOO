using System;
class Exercicio9 {
  static void Main() {
    int inicio = int.Parse(Console.ReadLine());
    int fim = int.Parse(Console.ReadLine());
    Console.WriteLine(Soma(inicio, fim));
  }
  public static int Soma(int inicio, int fim) {
    int soma = 0;
    fim--;
    while (fim > inicio) {
      soma += fim;
      fim--;
    }
    return soma;
  }
}