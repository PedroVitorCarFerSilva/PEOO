using System;

class exercicio5 {
  static void Main(){
    Console.Write("Diga seu nome completo: ");
    string nomec = Console.ReadLine();
    Console.WriteLine(In.FormatarNome(nomec));
  }
}

class In {
  public static string FormatarNome(string nome){
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
    return compnome;
  }
}