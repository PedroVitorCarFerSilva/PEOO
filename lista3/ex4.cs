using System;

class uri2416{
  static void Main(){
    string gabsferrari = Console.ReadLine();
    string[] cult = gabsferrari.Split();
    int fo = int.Parse(cult[0]);
    int tos = int.Parse(cult[1]);
    Console.WriteLine(fo%tos);
  }
}
