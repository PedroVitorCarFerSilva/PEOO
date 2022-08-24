using System;

class strings {
  static void Main() {
    Console.Write("Digite seu nome: ");
    string nome = Console.ReadLine();
    string[] nomer = nome.ToLower().Split();
    string compnome = "";
    foreach (string umnome in nomer) {
      if (umnome != "") {
        switch (umnome) {
          case "da":
          case "de":
          case "do":
          case "das":
          case "dos":
          case "e": compnome = compnome + umnome + " "; break;
          default: compnome = compnome + umnome.Substring(0,1).ToUpper() + umnome.Substring(1) + " "; break;
        }
      }
    }
    Console.WriteLine(compnome);
  }
}