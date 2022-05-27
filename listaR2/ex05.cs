using System;
class exercicio5 {
  static void Main(){
    Console.WriteLine("Informe o número do mês");
    int mesnum = int.Parse(Console.ReadLine());
    string mesnom = "<mês inválido>";
    string trimes = "<trimestre inválido>";
    switch (mesnum) {
      case 1:
      case 2:
      case 3:
        trimes = "primeiro"; 
        break;
      case 4:
      case 5:
      case 6:
        trimes = "segundo"; 
        break;
      case 7:
      case 8:
      case 9:
        trimes = "terceiro"; 
        break;
      case 10:
      case 11:
      case 12:
        trimes = "quarto"; 
        break;        
    }   
    if (mesnum == 1) mesnom = "janeiro";
    if (mesnum == 2) mesnom = "fevereiro";
    if (mesnum == 3) mesnom = "março";    
    if (mesnum == 4) mesnom = "abril";
    if (mesnum == 5) mesnom = "maio";
    if (mesnum == 6) mesnom = "junho";    
    if (mesnum == 7) mesnom = "julho";
    if (mesnum == 8) mesnom = "agosto";
    if (mesnum == 9) mesnom = "setembro";    
    if (mesnum == 10) mesnom = "outubro";
    if (mesnum == 11) mesnom = "novembro";
    if (mesnum == 12) mesnom = "dezembro";
    Console.WriteLine($"O mês de {mesnom} é do {trimes} trimestre do ano");
  }
}