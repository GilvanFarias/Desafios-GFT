using System;

class Desafio{
  
  public static void Main()
{

  string[] entrada = Console.ReadLine().Split(" ");
  double velocidade = double.Parse(entrada[0]);
  double tempo = double.Parse(entrada[1]);
  double distancia = velocidade * tempo ;

  double litros = distancia / 12;
  Console.WriteLine(litros.ToString("N3")); /*Ele divide uma string no dígito que for dado como parâmetro, 
  no caso é o espaço.Então ao invés e uma string "10 85" a gente vai ter os valores "10" e "85" como elementos de um array*/
  Console.Write(resultado);


}
}

