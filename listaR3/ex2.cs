using System;
class exercicio1 {
  static void Main() {
    int rep = 10;
    while (rep >= 1) {
      Console.Write(rep);
      if (rep != 1) Console.Write(" ");
      rep--;
    }
  }
}