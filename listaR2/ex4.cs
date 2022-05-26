using System;
class exercicio4 {
  static void Main(){
    Console.WriteLine("Digite o primeiro horário no formato hh:mm");
    string h1 = Console.ReadLine();
    Console.WriteLine("Digite o segundo horário no formato hh:mm");
    string h2 = Console.ReadLine();
    string[] hora1 = h1.Split(":");
    string[] hora2 = h2.Split(":");
    int min1 = int.Parse(hora1[1]);
    int hor1 = int.Parse(hora1[0]);
    int min2 = int.Parse(hora2[1]);
    int hor2 = int.Parse(hora2[0]);
    int minutos = min2 + min1;
    int horamin = 0;
    if (minutos >= 60) {
      horamin = minutos/60;
      minutos = minutos%60;
    }
    int horas = hor2 + hor1 + horamin;
    Console.WriteLine($"Total de horas = {horas:00}:{minutos:00}");
  }
}