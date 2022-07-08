using System;
class exercicio4 {
  static void Main() {
    int rep = 1;
    while (rep <= 30 && rep >= -30) {
      Console.Write(rep);
      rep = Math.Abs(rep) + 1;
      if (rep <= 30) Console.Write(" ");
      if (rep%3 == 0) rep = -rep;
    }
  }
}