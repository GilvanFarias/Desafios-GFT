using System;

class Desafio{
  
  public static void Main()
{

  string[] entrada = Console.ReadLine().Split(" "); //separar parte de uma string exemplo: string "10 85" a gente vai ter os valores "10" e "85".
  double velocidade = double.Parse(entrada[0]); //convertendo para double o indice [0] do array entrada
  double tempo = double.Parse(entrada[1]); //convertendo para double o indice [1] do array entrada
  double distancia = velocidade * tempo ;

  double litros = distancia / 12;
  Console.WriteLine(litros.ToString("N3")); /*Ele divide uma string no dígito que for dado como parâmetro, 
  no caso é o espaço.Então ao invés e uma string "10 85" a gente vai ter os valores "10" e "85" como elementos de um array*/
  Console.Write(resultado);


}
}

