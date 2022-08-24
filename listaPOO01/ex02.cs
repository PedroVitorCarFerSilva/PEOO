using System;
class Teste {
  public static void Main() {
    Disciplina d = new Disciplina();
    Console.WriteLine("Diga o nome da disciplina:");
    d.nome = Console.ReadLine();
    Console.WriteLine("Diga a nota do 1° bimestre:");
    d.nota1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Diga a nota do 2° bimestre:");
    d.nota2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Diga a nota do 3° bimestre:");
    d.nota3 = int.Parse(Console.ReadLine());
    Console.WriteLine("Diga a nota do 4° bimestre:");
    d.nota4 = int.Parse(Console.ReadLine());
    if (d.mediap() < 60) {
      Console.WriteLine("Diga a nota final:");
      d.notaf = int.Parse(Console.ReadLine());
      Console.WriteLine($"A sua media foi {d.mediaf()}");
    }
    else {
      Console.WriteLine($"A sua media é {d.mediap()}");
    }
    if (d.aprovado()) Console.WriteLine($"Você foi aprovado(a) em {d.nome}!");
    else Console.WriteLine($"Você foi reprovado(a) em {d.nome}...");
  }
}

class Disciplina {
  public string nome;
  public int nota1, nota2, nota3, nota4, notaf;
  public int mediap(){
    return (nota1*2 + nota2*2 + nota3*3 + nota4*3)/10;
  }
  public int mediaf(){
    if (mediap() >= 60) return mediap();
    else return (mediap()+notaf)/2;
  }
  public bool aprovado(){
    return mediaf() >= 60;
  }
}