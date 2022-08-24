using System;
class Exercicio10 {
  static void Main() {
    string s = Console.ReadLine();
    Console.WriteLine(Vogais(s));
  }
  public static string Vogais(string s) {
    string n = "";
    char a = 'a';
    char e = 'e';
    char i = 'i';
    char o = 'o';
    char u = 'u';
    foreach (char l in s) {
      if (l == a) {
        n = n + 'a';
      }
      if (l == e) {
        n = n + 'e';
      }
      if (l == i) {
        n = n + 'i';
      }
      if (l == o) {
        n = n + 'o';
      }
      if (l == u) {
        n = n + 'u';
      }
    }
    return n;
  }
}