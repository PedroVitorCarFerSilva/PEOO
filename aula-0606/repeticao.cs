using System;
class rep{
  static void Main(){
    
    int i = 1;
    while (i <= 10) {
      i++;
      Console.WriteLine(i);
    }
    Console.WriteLine($"while: {i}");
    
    i = 1;
    for (i = 1; i <= 10; i++){
      Console.WriteLine(i);
    }
    Console.WriteLine($"for: {i}");

    i = 1;
    do {
      i++;
      Console.WriteLine(i);
    } while (i <= 10);
    Console.WriteLine($"dowhile: {i}");

    string y = "foreach";
    foreach (char x in y) {
      Console.WriteLine(x);
    }
  }
}