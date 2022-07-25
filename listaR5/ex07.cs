using System;
class Exercicio7 {
  static void Main() {
    int x = int.Parse(Console.ReadLine());
    AntecessorSucessor(x, out int antecessor, out int sucessor);
    Console.WriteLine($"{antecessor} {sucessor}");
  }
  public static void AntecessorSucessor (int x, out int antecessor, out int sucessor) {
    antecessor = x - 1;
    sucessor = x + 1;
  }
}