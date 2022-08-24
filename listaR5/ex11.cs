using System;
class Exercicio11 {
  static void Main() {
    string texto = Console.ReadLine();
    int pos = int.Parse(Console.ReadLine());
    Console.WriteLine(Palavra(texto, pos));
  }
  public static string Palavra(string texto, int pos) {
    string[] a = {};
    int z = 0;
    int pos2 = texto.IndexOf(" ");
    while (z <= pos) {
      texto = texto.Substring(pos2+1);
      a[z] = texto;
      z++;
    }
    return texto;
  }
}