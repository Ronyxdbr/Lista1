/*-------------------------------------------------------------------
Questão 5: Cálculo de Distância Percorrida
• Contextualização: Um veículo no jogo percorre uma certa distância em um tempo determinado.
• Comando: Crie um programa que receba a velocidade do veículo, o tempo de viagem e dois
multiplicadores (um para condições climáticas e outro para estado do veículo), e calcule a
distância total percorrida.

@Lista: 01 - Lógica de Programação
@Autor: Milton Roney de Oliveira Nobre
@Data: 19/08/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
    {
        double vel, temp, condcli, estadovei;

        Console.Write("Velocidade: ");
        double.TryParse(Console.ReadLine(), out vel);
        Console.Write("Tempo: ");
        double.TryParse(Console.ReadLine(), out temp);
        Console.Write("Multiplicador climático: ");
        double.TryParse(Console.ReadLine(), out condcli);
        Console.Write("Multiplicador estado do veículo: ");
        double.TryParse(Console.ReadLine(), out estadovei);

        System.Console.WriteLine($"Distância percorrida: {vel * temp * condcli * estadovei}");
        
        Console.WriteLine("\nPressione ENTER para fechar");
        Console.ReadLine();
    }
}