using System;
class uri1080{
  static void Main(){
    int maior = 0;
    int pos = 0;
    for (int rep = 0; rep < 100; rep++) {
      int davez = int.Parse(Console.ReadLine());
      if (maior < davez) {
        maior = davez;
        pos = rep;
      }
    }
    Console.WriteLine(maior);
    Console.WriteLine(pos-1);
  }
}