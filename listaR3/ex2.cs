using System;
class exercicio2 {
  static void Main() {
    int rep = 10;
    while (rep >= 1) {
      Console.Write(rep);
      if (rep != 1) Console.Write(" ");
      rep--;
    }
  }
}