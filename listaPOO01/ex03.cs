using System;
class Teste {
  public static void Main() {
    Viagem v = new Viagem();
    Console.WriteLine("Diga a distância em quilômetros:");
    v.distancia = double.Parse(Console.ReadLine());
    Console.WriteLine("Diga o tempo em horas:");
    v.tempo = double.Parse(Console.ReadLine());
    Console.WriteLine($"A velocidade média desta viagem foi de {v.velocidademedia():0.0} km/h");
  }
}

class Viagem {
  public double distancia, tempo;
  public double velocidademedia() {
    return distancia/tempo;
  }
}