using System;
class exercicio3 {
  static void Main() {
    int rep = 1;
    while (rep <= 10 && rep >= -10) {
      Console.Write(rep);
      if (rep != -10) Console.Write(" ");
      if (rep > 0) rep = (rep + 1) * -1;
      else rep = (rep - 1) * -1;
    }
  }
}