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
        double forca, poder, bonushab, modcrit, modtipo;

        
        Console.Write("Força: ");
        double.TryParse(Console.ReadLine(), out forca);
        Console.Write("Poder da arma: ");
        double.TryParse(Console.ReadLine(), out poder);
        Console.Write("Bônus de habilidade: ");
        double.TryParse(Console.ReadLine(), out bonushab);
        Console.Write("Modificador crítico: ");
        double.TryParse(Console.ReadLine(), out modcrit);
        Console.Write("Modificador tipo de arma: ");
        double.TryParse(Console.ReadLine(), out modtipo);
        
        System.Console.WriteLine($"Total de ataque: {(forca + poder) * bonushab * modcrit * modtipo}");
       
        Console.WriteLine("\nPressione ENTER para fechar");
        Console.ReadLine();
    }
}