using System;
class uri2044{
  static void Main(){
    string fortnite = Console.ReadLine();
    string[] pokemongo = fortnite.Split();
    double lucas = double.Parse(pokemongo[0]);
    double lima = double.Parse(pokemongo[1]);
    double bas = 0;
    
    if (lucas > lima) {
      bas = lucas%lima;
    }
    else {
      bas = lima%lucas;
    }
    
    if (bas == 0) {
      Console.WriteLine("Sao Multiplos");
    }
    else {
      Console.WriteLine("Nao sao Multiplos");
    }
  }
}