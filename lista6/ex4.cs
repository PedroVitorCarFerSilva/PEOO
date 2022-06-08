using System;
class uri1114 {
  static void Main() {
    bool close = true;
    while (close) {
      string inserido = Console.ReadLine();
      if (inserido == "2002") {
        Console.WriteLine("Acesso Permitido");
        close = false;
      }
      else Console.WriteLine("Senha Invalida");
    }
  }
}