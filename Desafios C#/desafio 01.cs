using System;

class Desafio{
  
  public static void Main()
{

  string[] entrada = Console.ReadLine().Split(" ");
  double velocidade = double.Parse(entrada[0]);
  double tempo = double.Parse(entrada[1]);
  double distancia = velocidade * tempo ;

  double litros = distancia / 12;
  double resultado = Math.Round(litros, 3);
  Console.Write(resultado);


}
}

