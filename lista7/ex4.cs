using System;
class exercicio4 {
  static void Main() {
    Console.WriteLine("Insira as notas do aluno:");
    int nota1 = int.Parse(Console.ReadLine());
    int nota2 = int.Parse(Console.ReadLine());
    bool aprov = Not.Aprovado(nota1, nota2);
    if (aprov) {
      Console.WriteLine("Aprovado!");
    }
    else {
      Console.WriteLine("Reprovado :(");
    }
  }
}

class Not {
  public static bool Aprovado(int nota1, int nota2) {
    bool ap = (nota1 + nota2) / 2 >= 60;
    return ap;
  }
}