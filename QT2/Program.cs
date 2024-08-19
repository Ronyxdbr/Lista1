/*-------------------------------------------------------------------
Questão 2: Pontuação Final
• Contextualização: No final de uma missão em um jogo, a pontuação do jogador é calculada com
base nos inimigos derrotados e pontos adicionais.
• Comando: Desenvolva um programa que receba o número de inimigos derrotados, a pontuação
por inimigo, bônus por missão, e dois multiplicadores (um para tipo de inimigo e outro para
dificuldade), e então calcule e exiba a pontuação final.

@Lista: 01 - Lógica de Programação
@Autor: Milton Roney de Oliveira Nobre
@Data: 19/08/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
    {
        double kills, ppi, bpm, tipo, difi, pontos;

        
        Console.Write("Inimigos derrotados: ");
        double.TryParse(Console.ReadLine(), out kills);
        Console.Write("Pontos por inimigo: ");
        double.TryParse(Console.ReadLine(), out ppi);
        Console.Write("Bônus por missão: ");
        double.TryParse(Console.ReadLine(), out bpm);
        Console.Write("Multiplicador tipo inimigo: ");
        double.TryParse(Console.ReadLine(), out tipo);
        Console.Write("Multiplicador dificuldade: ");
        double.TryParse(Console.ReadLine(), out difi);
        
        pontos = (kills * ppi) * tipo * difi + bpm;
        System.Console.WriteLine($"Pontuação final: {pontos}");
       
        Console.WriteLine("\nPressione ENTER para fechar");
        Console.ReadLine();
    }
}