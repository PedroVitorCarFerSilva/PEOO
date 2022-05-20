using System;
class uri2424 {
  static void Main(){
    string balbino = Console.ReadLine();
    string[] renan = balbino.Split();
    double chess = double.Parse(renan[0]);
    double basquete = double.Parse(renan[1]);
    if (chess >= 0 && basquete >= 0 && chess < 433 && basquete < 469) {
      Console.WriteLine("dentro");
    }
    else {
      Console.WriteLine("fora");
    }
  }
}