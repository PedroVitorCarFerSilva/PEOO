using System;

class exercicio3 {
  static void Main() {
    Console.Write("Diga seu nome completo: ");
    string nome = Console.ReadLine();
    string nomei = In.Iniciais(nome);
    Console.WriteLine(nomei);
  }
}

class In {
  public static string Iniciais(string x) {
    string[] nome = x.Split();
    string inicial = "";
    foreach (string s in nome) {
      switch (s) {
      case "da":
      case "de":
      case "do":
      case "das":
      case "dos":
      case "e":
          break;
      default:
        inicial = inicial + s.Substring(0,1).ToUpper();
          break;
      }
    }
    return inicial;
  }
}